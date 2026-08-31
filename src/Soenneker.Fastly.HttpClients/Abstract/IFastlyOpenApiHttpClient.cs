using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Fastly.HttpClients.Abstract;

/// <summary>
/// Provides the configured HTTP client used to call the Fastly API.
/// </summary>
public interface IFastlyOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the shared Fastly HTTP client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The configured HTTP client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
