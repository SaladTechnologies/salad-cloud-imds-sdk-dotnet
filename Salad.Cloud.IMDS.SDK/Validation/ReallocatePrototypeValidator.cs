namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

public class ReallocatePrototypeValidator : AbstractValidator<ReallocatePrototype?>
{
    public ReallocatePrototypeValidator()
    {
        RuleFor(ReallocatePrototype => ReallocatePrototype.Reason)
            .MinimumLength(1)
            .WithMessage("Minimum length for reason is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for reason is 1.")
            .NotNull()
            .WithMessage("Field reason is required.");
    }
}
