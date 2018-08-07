using FluentValidation;
using System;
using Watcher.Common.Requests;

namespace Watcher.Common.Validators
{
    public class DashboardValidator : AbstractValidator<DashboardRequest>
    {
        public DashboardValidator()
        {
            RuleFor(x => x.Title).NotEmpty().Length(2, 50).WithMessage("Please specify a valid Title. Max length: 50, Min length: 3");
            RuleFor(x => x.InstanceId).NotEmpty().Must(i => i > 0).WithMessage("Please specify a valid Instance Id. Min value: 1");
            RuleFor(x => x.CreatedAt).NotEmpty().Must(BeAValidCreationDate).WithMessage($"Please specify a valid Creation Date. Sample Creation Date have to be between {DateTime.UtcNow.AddYears(-50).ToShortDateString()} and {DateTime.UtcNow.ToShortDateString()}");
        }

        private bool BeAValidCreationDate(DateTime date)
        {
            if (date > DateTime.UtcNow || date < DateTime.UtcNow.AddYears(-50))
                return false;

            return true;
        }
    }
}
