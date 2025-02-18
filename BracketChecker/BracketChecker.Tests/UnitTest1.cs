namespace BracketChecker.Tests;

using Xunit;

public class BracketTests
{
    [Theory]
    [InlineData("<>", true)]
    [InlineData("><", false)]
    [InlineData("<<>", false)]
    [InlineData("", true)]
    [InlineData("<abc...xyz>", true)]
    [InlineData("<<>>", true)]
    [InlineData("<<<>>>", true)]
    [InlineData("<<><>>", true)]
    [InlineData("<<<>>", false)]
    public void TestBracketMatching(string input, bool expected)
    {
        BracketCheckWorker checker = new();
        bool result = BracketCheckWorker.HasMatchingBrackets(input);
        Assert.Equal(expected, result);
    }
}

