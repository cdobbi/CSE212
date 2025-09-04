public static class Sorting
{
    public static void Run()
    {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data)
    {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--)
        {
            for (var swapPos = 0; swapPos < sortPos; ++swapPos)
            {
                if (data[swapPos] > data[swapPos + 1])
                {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}

//Big O(n^2)
//  uses a nested loop structure (like Bubble Sort), which means its Big O notation is O(n²). This describes quadratic time complexity, where the number of operations grows rapidly as the number of elements increases.