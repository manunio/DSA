using Xunit;

namespace Grind75.Tests;

public class StockSlidingWindowTests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    public void MaxProfitSlidingApproach_ShouldReturnExpectedResult(int[] prices, int expected)
    {
        // Act
        var result = StockSlidingWindow.MaxProfitSlidingApproach(prices);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    public void MaxProfitGreedyApproach_ShouldReturnExpectedResult(int[] prices, int expected)
    {
        // Act
        var result = StockSlidingWindow.MaxProfitGreedyApproach(prices);

        // Assert
        Assert.Equal(expected, result);
    }
}
