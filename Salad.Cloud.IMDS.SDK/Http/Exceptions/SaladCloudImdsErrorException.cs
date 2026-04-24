using Salad.Cloud.IMDS.SDK.Models;

namespace Salad.Cloud.IMDS.SDK.Http.Exceptions;

public class SaladCloudImdsErrorException : ApiException
{
    /// <summary>The error response associated with this exception.</summary>
    public SaladCloudImdsError SaladCloudImdsError { get; }

    /// <summary>
    /// Initializes a new instance of the SaladCloudImdsErrorException class with an inner exception.
    /// </summary>
    /// <param name="saladCloudImdsError">The SaladCloudImdsError associated with this exception.</param>
    /// <param name="responseMessage">The HTTP response message.</param>
    public SaladCloudImdsErrorException(
        SaladCloudImdsError saladCloudImdsError,
        HttpResponseMessage responseMessage
    )
        : base(responseMessage)
    {
        SaladCloudImdsError = saladCloudImdsError;
    }
}
