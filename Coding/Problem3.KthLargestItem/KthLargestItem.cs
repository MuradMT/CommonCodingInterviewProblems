using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Problem3.KthLargestItem
{
    public class KthLargestItem
    {
        //Massivin k-ci en boyuk elementini tap
        /*Main Program Code
         int[] arr = { 4, 2, 9, 7, 5, 6, 7, 1, 3 };
            Console.WriteLine("Please enter k:");
            int k=int.Parse(Console.ReadLine());
            Console.WriteLine(Result(arr,k));
            Console.ReadLine();
         */
        static int Result(int[] arr, int k)
        {
            Array.Sort(arr);
            return arr[arr.Length - k];
        }
    }
}
