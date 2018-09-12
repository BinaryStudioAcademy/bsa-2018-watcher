using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;

using FluentValidation;
using FluentValidation.Internal;

using ServiceBus.Shared.Messages;

namespace DataAccumulator.BusinessLayer.Validators
{
    public class ThresholdsValidatorCore : IThresholdsValidatorCore<CollectedDataDto>
    {
        private readonly IInstanceSettingsService<InstanceSettingsDto> _instanceValidatorService;
        private readonly IServiceBusProvider _serviceBusProvider;

        public ThresholdsValidatorCore(IInstanceSettingsService<InstanceSettingsDto> instanceValidatorService, 
            IServiceBusProvider serviceBusProvider)
        {
            _instanceValidatorService = instanceValidatorService;
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
                if (instanceValidatorDto.RamValidator) validatorParams.Add("RamUsage");
                if (instanceValidatorDto.LocalDiskVallidator) validatorParams.Add("LocalDiskUsage");
                if (instanceValidatorDto.CpuValidator) validatorParams.Add("CpuUsage");

                var context = new ValidationContext<CollectedDataDto>(collectedDataDto, 
                    new PropertyChain(), new RulesetValidatorSelector(validatorParams.ToArray()));

                var validationResult = await validator.ValidateAsync(context);
                if (!validationResult.IsValid)
                {
                    var message = new InstanceNotificationMessage()
                    {
                        InstanceId = instanceValidatorDto.ClientId,
                        Text = validationResult.ToString()
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
