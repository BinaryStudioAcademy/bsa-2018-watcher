namespace Watcher.Common.Validators
{
    using System;
    using FluentValidation;

    using Watcher.Common.Requests;

    public class PlaneValidator : AbstractValidator<SampleRequest>
    {
        public PlaneValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(2, 50).WithMessage("Please specify a valid Name. Max length: 50, Min length: 3");
            RuleFor(x => x.Count).NotEmpty().Must(c => c > 5 && c < 20).WithMessage("Please specify a valid Count. Max value: 19, Min value: 6");
            RuleFor(x => x.CreationDate).NotEmpty().Must(BeAValidCreationDate).WithMessage($"Please specify a valid Creation Date. Sample Creation Date have to be between {DateTime.UtcNow.AddYears(-50).ToShortDateString()} and {DateTime.UtcNow.ToShortDateString()}");
            RuleFor(x => x.SampleField).NotEmpty().WithMessage("Please specify a valid SampleField");
        }

        private bool BeAValidCreationDate(DateTime date)
        {
            if (date > DateTime.UtcNow || date < DateTime.UtcNow.AddYears(-50))
                return false;

            return true;
        }
    }
}
