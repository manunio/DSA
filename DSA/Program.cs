
internal class Program
{
    private static void Main(string[] args)
    {
        DSA.DArray<int> arr = new(5);

        for (int i = 0; i < 3; i++)
        {
            arr.Add(i + 1);
        }

        Print(arr);

        arr.RemoveAt(1); // removes 2 via index 1

        Print(arr);

        arr.Add(4);
        arr.Add(5);
        arr.Add(6);

        arr.Remove(5); // removes 5

        Print(arr);

        Console.WriteLine(arr.Contains(5)); // False
        Console.WriteLine(arr.Contains(6)); // True

        Console.WriteLine();

        Console.WriteLine(arr.IndexOf(5)); // -1
        Console.WriteLine(arr.IndexOf(6)); // 3


    }

    private static void Print(DSA.DArray<int> arr)
    {
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}