using Xunit.Abstractions;

namespace Kassei.TestKit.IntegrationTests;

public class TextContextBaseTests : TestContextBase
{
    [Fact]
    public void WriteTextToLine()
    {
        WriteLine("Hello World!");
    }

    public TextContextBaseTests(ITestOutputHelper logger) : base(logger) { }
}