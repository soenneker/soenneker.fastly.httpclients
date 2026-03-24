using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Fastly.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Fastly.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class FastlyOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="FastlyOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddFastlyOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IFastlyOpenApiHttpClient, FastlyOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="FastlyOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddFastlyOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IFastlyOpenApiHttpClient, FastlyOpenApiHttpClient>();

        return services;
    }
}
