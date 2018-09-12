using System;
using System.Collections.Generic;
using System.Text;
using DataAccumulator.Shared.Models;
using FluentValidation;

namespace DataAccumulator.BusinessLayer.Validators
{
    public class CollectedDataThresholdsValidator : AbstractValidator<CollectedDataDto>
    {
        public CollectedDataThresholdsValidator(InstanceSettingsDto instanceValidatorDto)
        {
            RuleFor(d => d.ClientId)
                .NotNull()
                .NotEqual(Guid.Empty);

            RuleSet("Ram", () =>
            {
                RuleFor(d => d.RamUsagePercentage)
                    .NotNull()
                    .LessThan(instanceValidatorDto.RamUsagePercentageMax);
            });

            RuleSet("Disk", () =>
            {
                RuleFor(d => d.LocalDiskUsagePercentage)
                    .NotNull()
                    .LessThan(instanceValidatorDto.LocalDiskUsagePercentageMax);
            });

            RuleSet("Cpu", () =>
            {
                RuleFor(d => d.CpuUsagePercentage)
                    .NotNull()
                    .LessThan(instanceValidatorDto.CpuUsagePercentageMax);
            });
        }
    }
}
