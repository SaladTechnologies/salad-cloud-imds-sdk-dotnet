namespace Salad.Cloud.IMDS.SDK.Hooks;

public class CustomHook : IHook
{
    public Task<HttpRequestMessage> BeforeRequestAsync(
        HttpRequestMessage request,
        Dictionary<string, string?> additionalParameters
    )
    {
        request.Headers.Add("Metadata", "true");
        return Task.FromResult(request);
    }

    public Task<HttpResponseMessage> AfterResponseAsync(
        HttpResponseMessage response,
        Dictionary<string, string?> additionalParameters
    )
    {
        return Task.FromResult(response);
    }

    public Task OnErrorAsync(
        HttpResponseMessage response,
        Dictionary<string, string?> additionalParameters
    )
    {
        return Task.CompletedTask;
    }
}
