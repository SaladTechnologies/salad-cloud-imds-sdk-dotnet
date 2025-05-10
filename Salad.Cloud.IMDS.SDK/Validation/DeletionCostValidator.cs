namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

public class DeletionCostValidator : AbstractValidator<DeletionCost?>
{
    public DeletionCostValidator()
    {
        RuleFor(DeletionCost => DeletionCost.DeletionCost1)
            .GreaterThanOrEqualTo(-2147483648)
            .WithMessage("Minimum for deletion_cost is -2147483648.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for deletion_cost is 2147483647.")
            .NotNull()
            .WithMessage("Field deletion_cost is required.");
    }
}
