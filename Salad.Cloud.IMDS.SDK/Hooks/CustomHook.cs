namespace Salad.Cloud.IMDS.SDK.Hooks;

public class CustomHook : IHook
{
    public Task<HttpRequestMessage> BeforeRequestAsync(HttpRequestMessage request)
    {
        request.Headers.Add("Metadata", "true");
        return Task.FromResult(request);
    }

    public Task<HttpResponseMessage> AfterResponseAsync(HttpResponseMessage response)
    {
        return Task.FromResult(response);
    }

    public Task OnErrorAsync(HttpResponseMessage response)
    {
        return Task.CompletedTask;
    }
}
