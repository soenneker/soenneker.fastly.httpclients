using Soenneker.Fastly.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Fastly.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FastlyOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IFastlyOpenApiHttpClient _httpclient;

    public FastlyOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IFastlyOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
