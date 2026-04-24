using System.Text.Json.Serialization;
using Salad.Cloud.IMDS.SDK.Json;

namespace Salad.Cloud.IMDS.SDK.Models;

public record Metadata1 : ValueEnum<string>
{
    internal Metadata1(string value)
        : base(value) { }

    public Metadata1()
        : base("true") { }

    public static Metadata1 True_ = new("true");
}
