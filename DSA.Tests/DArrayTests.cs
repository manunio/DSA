namespace DSA.Tests;
using DSA;

public sealed class DArrayTests
{
    [Fact]
    public void Add_And_Iterate_Works()
    {
        DArray<int> arr = CreateArrayWith(1, 2, 3);

        Assert.Equal(3, arr.Count);

        int[] expected = { 1, 2, 3 };
        int index = 0;

        foreach (var item in arr)
        {
            Assert.Equal(expected[index++], item);
        }
    }

    [Fact]
    public void RemoveAt_Works()
    {
        DArray<int> arr = CreateArrayWith(1, 2, 3);

        arr.RemoveAt(1); // removes 2
        Assert.Equal(2, arr.Count);
        Assert.False(arr.Contains(2));
    }

    [Fact]
    public void Remove_ByValue_Works()
    {
        DArray<int> arr = CreateArrayWith(4, 5, 6);

        bool removed = arr.Remove(5);
        Assert.True(removed);
        Assert.False(arr.Contains(5));
        Assert.True(arr.Contains(6));
    }

    [Fact]
    public void IndexOf_Contains_Works()
    {
        DArray<int> arr = CreateArrayWith(4, 5, 6);

        Assert.Equal(1, arr.IndexOf(5));
        Assert.Equal(2, arr.IndexOf(6));
        arr.Remove(5);
        Assert.Equal(-1, arr.IndexOf(5));

    }

    [Fact]
    public void Clear_Works()
    {
        DArray<int> arr = CreateArrayWith(10, 20);
        arr.Clear();

        Assert.True(arr.IsEmpty);
        Assert.Equal(0, arr.Count);

    }

    [Fact]
    public void Get_And_Set_Works()
    {
        DArray<int> arr = CreateArrayWith(100, 200);
        arr[1] = 999;

        Assert.Equal(999, arr[1]);

    }

    private static DArray<int> CreateArrayWith(params int[] values)
    {
        var arr = new DArray<int>();
        foreach (var val in values)
        {
            arr.Add(val);
        }
        return arr;
    }
}
