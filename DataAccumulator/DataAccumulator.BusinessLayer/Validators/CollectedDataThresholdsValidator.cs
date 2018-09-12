using System;

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

            RuleSet("RamUsage", () =>
            {
                RuleFor(d => d.RamUsagePercentage)
                    .NotNull()
                    .LessThan(instanceValidatorDto.RamUsagePercentageMax);
            });

            RuleSet("LocalDiskUsage", () =>
            {
                RuleFor(d => d.LocalDiskUsagePercentage)
                    .NotNull()
                    .LessThan(instanceValidatorDto.LocalDiskUsagePercentageMax);
            });

            RuleSet("CpuUsage", () =>
            {
                RuleFor(d => d.CpuUsagePercentage)
                    .NotNull()
                    .LessThan(instanceValidatorDto.CpuUsagePercentageMax);
            });
        }
    }
}
