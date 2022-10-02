using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;

namespace Coding
{
    internal class Program
    {
        static int Result(int[] arr,int k)
        {
            Array.Sort(arr);
            return arr[arr.Length-k];
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 9, 7, 5, 6, 7, 1, 3 };
            Console.WriteLine("Please enter k:");
            int k=int.Parse(Console.ReadLine());
            Console.WriteLine(Result(arr,k));
            Console.ReadLine();
        }
    }
}

