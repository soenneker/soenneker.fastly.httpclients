using Soenneker.Fastly.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Fastly.HttpClients.Tests;

[Collection("Collection")]
public sealed class FastlyOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IFastlyOpenApiHttpClient _httpclient;

    public FastlyOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IFastlyOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
