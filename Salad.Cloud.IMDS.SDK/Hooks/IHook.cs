namespace Salad.Cloud.IMDS.SDK.Hooks;

public interface IHook
{
    public Task<HttpRequestMessage> BeforeRequestAsync(
        HttpRequestMessage request,
        Dictionary<string, string?> additionalParameters
    );
    public Task<HttpResponseMessage> AfterResponseAsync(
        HttpResponseMessage response,
        Dictionary<string, string?> additionalParameters
    );
    public Task OnErrorAsync(
        HttpResponseMessage response,
        Dictionary<string, string?> additionalParameters
    );
}
