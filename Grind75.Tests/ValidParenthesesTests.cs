using Xunit;

namespace Grind75.Tests;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("([{}])", true)]
    [InlineData("([{})", false)]
    [InlineData("()[]{}", true)]
    public void StackApproach_ShouldValidateParenthesesCorrectly(string input, bool expected)
    {
        // Act
       var result = ValidParentheses.StackApproach(input);
        // Assert
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("([{}])", true)]
    [InlineData("([{})", false)]
    [InlineData("()[]{}", true)]
    public void StackApproach1_ShouldValidateParenthesesCorrectly(string input, bool expected)
    {
        // Act
        var result = ValidParentheses.StackApproach1(input);
        // Assert
        Assert.Equal(expected, result);
    }
}
