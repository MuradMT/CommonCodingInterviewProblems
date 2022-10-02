using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Problem1.Anagrams
{
    public class Anagrams
    {
        //Main Program Code
        //Console.WriteLine("Please enter first string:");
        //string first=Console.ReadLine();
        //Console.WriteLine("Please enter second string:");
        //string second = Console.ReadLine();
        //var solution=ResultChecker(first, second) ==
        //    true ? "The strings is anagram":
        //    "The strings is not anagram";
        //Console.WriteLine(solution);
        static bool CheckLengthForAnagram(string first, string second)
        {
            var result = first.Length != second.Length ? false : true;
            return result;
        }
        static string SortStrings(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);

            return new string(characters);
        }
        static bool ResultChecker(string first, string second)
        {
            var result = (CheckLengthForAnagram(first, second) &&
                SortStrings(first).Equals(SortStrings(second))) ? true : false;
            return result;
        }
    }
}
