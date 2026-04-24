namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

/// <summary>
/// FluentValidation validator for Token model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class TokenValidator : AbstractValidator<Token>
{
    public TokenValidator()
    {
        RuleFor(Token => Token.Jwt)
            .MinimumLength(1)
            .WithMessage("Minimum length for jwt is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for jwt is 1.")
            .NotNull()
            .WithMessage("Field jwt is required and cannot be null.");
    }
}
