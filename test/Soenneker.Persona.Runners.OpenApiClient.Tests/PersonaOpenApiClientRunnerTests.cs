using Soenneker.Tests.HostedUnit;

namespace Soenneker.Persona.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PersonaOpenApiClientRunnerTests : HostedUnitTest
{
    public PersonaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
