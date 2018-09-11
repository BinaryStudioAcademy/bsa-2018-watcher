using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using FluentValidation;
using FluentValidation.Internal;

using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;

using ServiceBus.Shared.Messages;
using ServiceBus.Shared.Enums;
using System.Text;
using System.Linq;

namespace DataAccumulator.BusinessLayer.Validators
{
    public class ThresholdsValidatorCore : IThresholdsValidatorCore<CollectedDataDto>
    {
        private readonly IInstanceSettingsService<InstanceSettingsDto> _instanceValidatorService;
        private readonly IServiceBusProvider _serviceBusProvider;

        public ThresholdsValidatorCore(IInstanceSettingsService<InstanceSettingsDto> instanceSettingService, 
            IServiceBusProvider serviceBusProvider)
        {
            _instanceValidatorService = instanceSettingService;
            _serviceBusProvider = serviceBusProvider;
        }

        public async Task Validate(CollectedDataDto collectedDataDto)
        {
            try
            {
                var instanceValidatorDto = await _instanceValidatorService
                    .GetEntityByInstanceIdAsync(collectedDataDto.ClientId);


                var validator = new CollectedDataThresholdsValidator(instanceValidatorDto);

                var validatorParams = new List<string>();
                if (instanceValidatorDto.RamValidator) validatorParams.Add("Ram");
                if (instanceValidatorDto.LocalDiskVallidator) validatorParams.Add("Disk");
                if (instanceValidatorDto.CpuValidator) validatorParams.Add("Cpu");

                var context = new ValidationContext<CollectedDataDto>(collectedDataDto, 
                    new PropertyChain(), new RulesetValidatorSelector(validatorParams.ToArray()));

                var validationResult = await validator.ValidateAsync(context);

                if (!validationResult.IsValid)
                {
                    StringBuilder textMessage = new StringBuilder();

                    foreach (var item in validationResult.Errors)
                    {
                        var name = item.FormattedMessagePlaceholderValues["PropertyName"]
                            .ToString();

                        int index = name.IndexOf("Percentage");
                        name = (index < 0)
                            ? name
                            : name.Remove(index, "Percentage".Length);

                        index = name.IndexOf("Local");
                        name = (index < 0)
                           ? name
                           : name.Remove(index, "Local".Length);

                        name = name.ToLower();

                        textMessage.Append(" " + name + " has reached " + item.AttemptedValue.ToString().Substring(0, 4) + "% ");
                    }
                    var message = new InstanceNotificationMessage()
                    {
                        InstanceId = instanceValidatorDto.ClientId,
                        CreatedAt = DateTime.Now,
                        Type = InstanceNotifyType.Error,
                        Text = textMessage.ToString()
                    };
                    await _serviceBusProvider.SendNotificationMessage(message);
                }
            }
            catch (NotFoundException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
