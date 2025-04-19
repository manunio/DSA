using Xunit;

namespace Grind75.Tests;

public class MergeTwoSortedListsTests
{
    [Fact]
    public void Run_BothListsEmpty_ReturnsNull()
    {
        // Arrange
        ListNode? list1 = null;
        ListNode? list2 = null;

        // Act
        var result = MergeTwoSortedLists.Run(list1, list2);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Run_OneListEmpty_ReturnsOtherList()
    {
        // Arrange
        var list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        ListNode? list2 = null;

        // Act
        var result = MergeTwoSortedLists.Run(list1, list2);

        // Assert
        Assert.Equal(list1, result);
    }

    [Fact]
    public void Run_BothListsNonEmpty_ReturnsMergedSortedList()
    {
        // Arrange
        var list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        var list2 = new ListNode(2, new ListNode(4, new ListNode(6)));

        // Act
        var result = MergeTwoSortedLists.Run(list1, list2);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next!.val);
        Assert.Equal(3, result.next.next!.val);
        Assert.Equal(4, result.next.next.next!.val);
        Assert.Equal(5, result.next.next.next.next!.val);
        Assert.Equal(6, result.next.next.next.next.next!.val);
        Assert.Null(result.next.next.next.next.next.next);
    }

    [Fact]
    public void Run_ListsWithDuplicateValues_ReturnsMergedSortedList()
    {
        // Arrange
        var list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(5)));

        // Act
        var result = MergeTwoSortedLists.Run(list1, list2);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Equal(1, result.next!.val);
        Assert.Equal(3, result.next.next!.val);
        Assert.Equal(3, result.next.next.next!.val);
        Assert.Equal(5, result.next.next.next.next!.val);
        Assert.Equal(5, result.next.next.next.next.next!.val);
        Assert.Null(result.next.next.next.next.next.next);
    }

    [Fact]
    public void Run_ListsWithNegativeValues_ReturnsMergedSortedList()
    {
        // Arrange
        var list1 = new ListNode(-3, new ListNode(-1, new ListNode(2)));
        var list2 = new ListNode(-2, new ListNode(0, new ListNode(3)));

        // Act
        var result = MergeTwoSortedLists.Run(list1, list2);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(-3, result.val);
        Assert.Equal(-2, result.next!.val);
        Assert.Equal(-1, result.next.next!.val);
        Assert.Equal(0, result.next.next.next!.val);
        Assert.Equal(2, result.next.next.next.next!.val);
        Assert.Equal(3, result.next.next.next.next.next!.val);
        Assert.Null(result.next.next.next.next.next.next);
    }

    [Fact]
    public void Run_ListsWithSingleElementEach_ReturnsMergedSortedList()
    {
        // Arrange
        var list1 = new ListNode(1);
        var list2 = new ListNode(2);

        // Act
        var result = MergeTwoSortedLists.Run(list1, list2);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next!.val);
        Assert.Null(result.next.next);
    }
}
