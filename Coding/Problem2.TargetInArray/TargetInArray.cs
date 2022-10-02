using System;

namespace Coding.Problem2.TargetInArray
{
    public class TargetInArray
    {
        /* Main Program Code
        int[] arr = { 2, 4, 5, 5, 5, 5, 5, 7, 9, 9 };
        Console.WriteLine("Please enter target:");
        int target = int.Parse(Console.ReadLine());
        var res = Result(FindFirstIndex, FindLastIndex, arr, target);
        Console.WriteLine($"Result is:[{res.Item1},{res.Item2}]");
        Console.ReadLine();
        */
        static int FindFirstIndex(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static int FindLastIndex(int[] arr, int target)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static (int, int) Result(Func<int[], int, int> first,
            Func<int[], int, int> second, int[] arr, int target)
        {
            return (first.Invoke(arr, target), second.Invoke(arr, target));
        }
    }
}
