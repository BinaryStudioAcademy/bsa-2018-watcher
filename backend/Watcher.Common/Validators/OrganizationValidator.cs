namespace Watcher.Common.Validators
{
    using FluentValidation;

    using Watcher.Common.Requests;

    public class OrganizationValidator : AbstractValidator<OrganizationRequest>
    {
        public OrganizationValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(2, 50).WithMessage("Please specify a valid Name. Max length: 50, Min length: 3");
            RuleFor(x => x.CreatedByUserId).NotEmpty().WithMessage("Please specify userId, who registered organization");
        }
    }
}
