namespace Salad.Cloud.IMDS.SDK.Http;

using Salad.Cloud.IMDS.SDK.Http.Extensions;

/// <summary>
/// The environments available for the SDK.
/// </summary>
public class Environment
{
    internal Uri Uri { get; private set; }
    internal string OriginalString { get; private set; }

    private Environment(string uri)
    {
        OriginalString = uri;
        Uri = new Uri(uri);
    }

    public static Environment Default { get; } = new("http://169.254.169.254/");
}
