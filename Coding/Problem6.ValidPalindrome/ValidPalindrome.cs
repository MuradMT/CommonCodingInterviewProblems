using System;
using System.Text;

namespace Coding.Problem6.ValidPalindrome
{
    
    public class ValidPalindrome
    {
        static bool IsPalindrome(string palindrome)
        {
            string res = "";
            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                res += palindrome[i];
            }
            return palindrome == res;
        }
        static bool IsCharacter(char symbol)
        {
            return char.IsLetterOrDigit(symbol);
        }
        //Main program Code
        //string some = Console.ReadLine().Trim().ToLower();
        //StringBuilder sb = new StringBuilder();
        //    foreach (char c in some)
        //    {
        //        if(IsCharacter(c)) sb.Append(c);
        //    }
        //Console.WriteLine(IsPalindrome(sb.ToString()));
    }
}
