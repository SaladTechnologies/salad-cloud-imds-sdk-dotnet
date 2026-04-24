namespace Salad.Cloud.IMDS.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.IMDS.SDK.Models;

/// <summary>
/// FluentValidation validator for Metadata1 model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class Metadata1Validator : AbstractValidator<Metadata1>
{
    public Metadata1Validator() { }
}
