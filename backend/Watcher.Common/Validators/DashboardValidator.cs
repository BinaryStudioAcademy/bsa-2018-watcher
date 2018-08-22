using FluentValidation;

using Watcher.Common.Requests;

namespace Watcher.Common.Validators
{
    public class DashboardValidator : AbstractValidator<DashboardRequest>
    {
        public DashboardValidator()
        {
            RuleFor(x => x.Title).NotEmpty().Length(2, 50).WithMessage("Please specify a valid Title. Max length: 50, Min length: 2");
            RuleFor(x => x.InstanceId).NotEmpty().Must(i => i > 0).WithMessage("Please specify a valid Instance Id. Min value: 1");
        }
    }
}
