using Salad.Cloud.IMDS.SDK.Hooks;

namespace Salad.Cloud.IMDS.SDK.Http.Handlers;

/// <summary>
/// A handler for executing lifecycle hooks for the request.
/// </summary>
public class HookHandler : DelegatingHandler
{
    private readonly IHook hook;

    internal HookHandler(IHook hook, HttpMessageHandler? innerHandler = null)
        : base(innerHandler ?? new HttpClientHandler())
    {
        this.hook = hook;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        request = await this.hook.BeforeRequestAsync(request);

        var response = await base.SendAsync(request, cancellationToken);

        if (response.IsSuccessStatusCode)
            return await this.hook.AfterResponseAsync(response);

        await this.hook.OnErrorAsync(response);
        return response;
    }
}
