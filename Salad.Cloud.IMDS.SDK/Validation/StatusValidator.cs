namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

/// <summary>
/// FluentValidation validator for Status model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class StatusValidator : AbstractValidator<Status>
{
    public StatusValidator()
    {
        RuleFor(Status => Status.Ready)
            .NotNull()
            .WithMessage("Field ready is required and cannot be null.");
        RuleFor(Status => Status.Started)
            .NotNull()
            .WithMessage("Field started is required and cannot be null.");
    }
}
