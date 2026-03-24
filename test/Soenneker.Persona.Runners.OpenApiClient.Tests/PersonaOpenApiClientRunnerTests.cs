using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Persona.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PersonaOpenApiClientRunnerTests : FixturedUnitTest
{
    public PersonaOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
