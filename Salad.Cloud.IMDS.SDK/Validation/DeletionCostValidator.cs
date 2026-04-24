namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

/// <summary>
/// FluentValidation validator for DeletionCost model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class DeletionCostValidator : AbstractValidator<DeletionCost>
{
    public DeletionCostValidator()
    {
        RuleFor(DeletionCost => DeletionCost.DeletionCost1)
            .GreaterThanOrEqualTo(-2147483648)
            .WithMessage("Minimum for deletion_cost is -2147483648.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for deletion_cost is 2147483647.")
            .NotNull()
            .WithMessage("Field deletion_cost is required and cannot be null.");
    }
}
