namespace Grind75.Tests;

public static class TwoSumTestData
{
    public static IEnumerable<object[]> Testcases =>
        [
            [new int[] { 2, 7, 11, 15 }, 9, new int[] {0, 1}],
            [new int[] { 3 , 2 , 4 }, 6 ,new int[] {1, 2}],
            [new int[] {1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 5, 11 } ]
        ];
}

public sealed class TwoSumTest
{

    [Theory]
    [MemberData(nameof(TwoSumTestData.Testcases), MemberType = typeof(TwoSumTestData))]
    public void TestBruteForceApproach(int[] nums, int target, int[] expected)
    {
        int[] result = TwoSum.BruteForceApproach(nums, target);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(TwoSumTestData.Testcases), MemberType = typeof(TwoSumTestData))]
    public void TestHashApproach(int[] nums, int target, int[] expected)
    {
        int[] result = TwoSum.HashMapApproach(nums, target);
        Assert.Equal(expected, result);
    }
}
