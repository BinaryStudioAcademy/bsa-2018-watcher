namespace Watcher.Common.Validators
{
    using FluentValidation;

    using Watcher.Common.Requests;

    public class ChartValidator : AbstractValidator<ChartRequest>
    {
        public ChartValidator()
        {
            // RuleFor(x => x.Type).NotEmpty().WithMessage("Please specify a valid Type.");
            // RuleFor(x => x.ShowCommon).NotEmpty().WithMessage($"Please specify a valid Show Common. Max length: 50, Min length: 2");
            // RuleFor(x => x.Threshold).NotEmpty().Must(i => i > 0).WithMessage($"Please specify a valid Threshold. Max value: {int.MaxValue - 1}, Min value: 0");
            // RuleFor(x => x.MostLoaded).NotEmpty().Length(2, 50).WithMessage($"Please specify a valid Most Loaded. Max length: 50, Min length: 2");
            RuleFor(x => x.DashboardId).NotEmpty().Must(i => i > 0).WithMessage($"Please specify a valid Dashboard Id. Max value: {int.MaxValue - 1}, Min value: 0");
        }
    }
}
