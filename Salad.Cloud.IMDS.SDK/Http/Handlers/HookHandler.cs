using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Hooks;

namespace Salad.Cloud.IMDS.SDK.Http.Handlers;

/// <summary>
/// A handler for executing lifecycle hooks for the request.
/// </summary>
public class HookHandler : DelegatingHandler
{
    private readonly IHook hook;
    private readonly Dictionary<string, string?> additionalParameters = new();

    internal HookHandler(
        IHook hook,
        SaladCloudImdsSdkConfig? config = null,
        HttpMessageHandler? innerHandler = null
    )
        : base(innerHandler ?? new HttpClientHandler())
    {
        this.hook = hook;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        request = await this.hook.BeforeRequestAsync(request, this.additionalParameters);

        var response = await base.SendAsync(request, cancellationToken);

        if (response.IsSuccessStatusCode)
            return await this.hook.AfterResponseAsync(response, this.additionalParameters);

        await this.hook.OnErrorAsync(response, this.additionalParameters);
        return response;
    }
}
