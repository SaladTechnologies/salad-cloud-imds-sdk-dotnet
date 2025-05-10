namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

public class StatusValidator : AbstractValidator<Status?>
{
    public StatusValidator()
    {
        RuleFor(Status => Status.Ready).NotNull().WithMessage("Field ready is required.");
        RuleFor(Status => Status.Started).NotNull().WithMessage("Field started is required.");
    }
}
