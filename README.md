[![](https://img.shields.io/nuget/v/soenneker.fastly.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.fastly.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.fastly.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.fastly.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.fastly.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.fastly.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.fastly.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.fastly.httpclients/actions/workflows/codeql.yml)

# Soenneker.Fastly.HttpClients

Provides a cached `HttpClient` configured for Fastly API requests.

## Installation

```bash
dotnet add package Soenneker.Fastly.HttpClients
```

## Configuration

```json
{
  "Fastly": {
    "ApiKey": "your-api-token"
  }
}
```

Requests use the `Fastly-Key` header and `https://api.fastly.com/` by default. `Fastly:AuthHeaderName`, `Fastly:AuthHeaderValueTemplate`, and `Fastly:ClientBaseUrl` can override those values.

## Registration and usage

```csharp
using Soenneker.Fastly.HttpClients.Abstract;
using Soenneker.Fastly.HttpClients.Registrars;

services.AddFastlyOpenApiHttpClientAsSingleton();

public sealed class FastlyRequestSender(IFastlyOpenApiHttpClient clients)
{
    public async Task<HttpResponseMessage> GetCurrentUser(CancellationToken cancellationToken)
    {
        HttpClient client = await clients.Get(cancellationToken);
        return await client.GetAsync("current_user", cancellationToken);
    }
}
```

Use the scoped registration only when each scope must own a separate client. Each provider instance owns its cache entry and removes that client when disposed.
