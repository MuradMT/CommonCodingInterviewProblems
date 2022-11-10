using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Problem5.ConvertStringGivenConsoleToMath
{
    public class Solution
    {
        /*Main Program Code
         * In this program we do mathematical operations on console,
         * after we can get the value of this operations.
         * There are 2 solution for this problem,
         * first i use ready way:
         * 1)var text=GetText();
         * DataTable dt = new DataTable();
         * int answer = (int)dt.Compute(text,"");
         * Console.WriteLine(answer);
         * Console.ReadLine();
         * Second i write solution from scratch,
         * i use different logic in every method,
         * this helps me to solve problem
         * only using 3 line code on Main Program
         * 2)var text=GetText();
         * Result(text);
         * Console.ReadLine();
         */
        static bool LengthChecker(string text)
        {
            if (text.Length % 2 == 0) return false;
            return true;
        }
        static bool IsNumber(char symbol)
        {
            if (symbol >= '0' && symbol <= '9') return true;

            return false;
        }
        static bool IsSymbol(char symbol)
        {
            var chars = new char[] { '+', '-', '*', '/' };
            if (chars.Contains(symbol)) return true;
            return false;
        }
        static bool TextChecker(string text)
        {
            if (!LengthChecker(text)) return false;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (!IsNumber(text[i])) return false;
                }
                else
                {
                    if (!IsSymbol(text[i])) return false;
                }
            }
            return true;
        }
        static List<string> StringSplitter(string text)
        {

            List<string> arr = text.Split(new char[] { '+' }).ToList();
            List<string> arr2 = new List<string>(arr);
            arr.Sort();
            arr2.Sort();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Contains('-'))
                {
                    var helper = arr2[i];
                    arr2.Remove(arr2[i]);
                    var operation = helper.Split('-');
                    for (int j = 0; j < operation.Length; j++)
                    {
                        if (j != 0) operation[j] = "-" + operation[j];
                        arr2.Add(operation[j]);
                    }
                }
            }


            return arr2;
        }
        static int ResultGenerator(string text)
        {
            int result = 0;
            bool val = false;
            if (text[0] == '-')
            {
                val = true;
                text = text.Substring(1, text.Length - 1);
            }
            for (int i = 1; i < text.Length; i += 2)
            {
                switch (text[i])
                {
                    case '+':
                        if (i == 1)
                        {
                            result = int.Parse(text[i - 1].ToString()) + int.Parse(text[i + 1].ToString());
                        }
                        else
                        {
                            result = result + int.Parse(text[i + 1].ToString());
                        }
                        break;
                    case '-':
                        if (i == 1)
                        {
                            result = int.Parse(text[i - 1].ToString()) - int.Parse(text[i + 1].ToString());
                        }
                        else
                        {
                            result = result - int.Parse(text[i + 1].ToString());
                        }
                        break;
                    case '*':
                        if (i == 1)
                        {
                            result = int.Parse(text[i - 1].ToString()) * int.Parse(text[i + 1].ToString());
                        }
                        else
                        {
                            result = result * int.Parse(text[i + 1].ToString());
                        }
                        break;
                    case '/':
                        if (i == 1)
                        {
                            result = int.Parse(text[i - 1].ToString()) / int.Parse(text[i + 1].ToString());
                        }
                        else
                        {
                            result = result / int.Parse(text[i + 1].ToString());
                        }
                        break;
                }
            }
            return val == true ? result * -1 : result;
        }
        static int CountGenerator(string text)
        {
            int count = 0;
            int res;
            var gen = int.TryParse(text, out res);
            if (gen)
            {
                count += res;
            }
            else
            {
                count += ResultGenerator(text);
            }
            return count;

        }
        static void Result(string text)
        {
            if (TextChecker(text))
            {
                int count = 0;
                var res = StringSplitter(text);
                foreach (var item in res)
                {
                    count += CountGenerator(item);
                }
                Console.WriteLine(count);

            }
            else
            {
                Console.WriteLine("Please enter right format");
            }
        }
        static string GetText()
        {
            var tex = Console.ReadLine().Trim().Split();
            string text = string.Empty;
            foreach (var item in tex)
            {
                text += item;
            }
            return text;
        }


    }
}
