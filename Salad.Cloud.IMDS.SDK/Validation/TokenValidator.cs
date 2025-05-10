namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

public class TokenValidator : AbstractValidator<Token?>
{
    public TokenValidator()
    {
        RuleFor(Token => Token.Jwt)
            .MinimumLength(1)
            .WithMessage("Minimum length for jwt is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for jwt is 1.")
            .NotNull()
            .WithMessage("Field jwt is required.");
    }
}
