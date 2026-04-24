namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

/// <summary>
/// FluentValidation validator for ReallocatePrototype model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ReallocatePrototypeValidator : AbstractValidator<ReallocatePrototype>
{
    public ReallocatePrototypeValidator()
    {
        RuleFor(ReallocatePrototype => ReallocatePrototype.Reason)
            .MinimumLength(1)
            .WithMessage("Minimum length for reason is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for reason is 1.")
            .NotNull()
            .WithMessage("Field reason is required and cannot be null.");
    }
}
