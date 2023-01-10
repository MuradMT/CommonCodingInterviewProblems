global using Coding.Problem1;
using Coding.Problem1.Anagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding
{


    public class Program
    {
        #region Mesele10
        //static string Result(string x, char[]arr)
        // {
        //     string a = default;
        //     string b = default;
        //     string def=default;
        //     if (x.Length != 3)
        //     {
        //         return "Emeliyyat dogru olmalidir";
        //     }
        //     else
        //     {
        //         for (int i = 0; i < 3; i++)
        //         {

        //             if (!arr.Contains(x[i]) && x[i] >= '0' && x[i] <= '9')
        //             {
        //                 if (i == 0)
        //                 {
        //                     a = x[i].ToString();
        //                 }
        //                 else if (i == 2)
        //                 {
        //                     b = x[i].ToString();
        //                 }

        //             }
        //             else if (arr.Contains(x[i]))
        //             {
        //                 def = x[i].ToString();
        //             }
        //             else
        //             {
        //                 return "Emeliyyatda ancaq reqemler islenmelidir";
        //             }
        //         }
        //         switch (def)
        //         {
        //             case "+":
        //                 return $"{Convert.ToInt32(a) + Convert.ToInt32(b)}";
        //             case "-":
        //                 return $"{Convert.ToInt32(a) - Convert.ToInt32(b)}";
        //             case "*":
        //                 return $"{Convert.ToInt32(a) * Convert.ToInt32(b)}";
        //             case "/":
        //                 return $"{Convert.ToInt32(a) / Convert.ToInt32(b)}";
        //         }
        //     }
        //     return "This is default";

        //}
        //static double Checker(string[] x, string[] y)
        //{
        //    if (x.Contains("AD") && y.Contains("AD"))
        //    {
        //        return Math.Abs(double.Parse(y[1]) - double.Parse(x[1]));
        //    }
        //    else if (x.Contains("BC") && y.Contains("AD"))
        //    {
        //        return Math.Abs(double.Parse(y[1]) - (double.Parse(x[0]) - 1) * -(1));
        //    }
        //    else if (x.Contains("AD") && y.Contains("BC"))
        //    {
        //        return Math.Abs((double.Parse(y[0]) - 1) * (-1) - (double.Parse(x[1])));
        //    }
        //    else if (x.Contains("BC") && y.Contains("BC"))
        //    {
        //        return Math.Abs((double.Parse(y[0]) - 1) * (-1) - (int.Parse(x[0]) - 1) * (-1));
        //    }
        //    return 0;
        //}

        //static (int,int) Combination(int a,int b,int c)
        //{
        //    //1700 500 200
        //    if (a % b == 0)
        //    {
        //        return (a / b, 0);
        //    }
        //    else if(a % c == 0)
        //    {
        //        return (a/c, 0);
        //    }
        //    else
        //    {
        //        var max = b > c ? b : c;
        //        var min = b < c ? b: c;
        //        var temp = a;
        //        var res=Math.Round((double)a / max);
        //        temp -= (int)res*max;
        //        var rs=Math.Round((double)a / min);
        //        temp -= (int)rs*min;
        //        if(temp == 0)
        //        {
        //            return ((int)res, (int)rs);
        //        }
        //        else
        //        {
        //            var res1= Math.Round((double)a / min);
        //            var res2= Math.Round((double)a / max);
        //            return ((int)res1, (int)res2);
        //        }

        //    }
        //    return (0, 0);
        //}
        //static string StringGetter(string emp)
        //{
        //    string res = string.Empty;
        //    for (int i = emp.Length - 1; i >= 0; i--)
        //    {
        //        res += emp[i];
        //    }

        //    return res;
        //}
        #endregion

        
        static void Main(string[] args)
        {
            #region Mesele10Main
            //char[] chars = {'+','-','*','/' };
            //string x = Console.ReadLine();
            //var res = Result(x, chars);
            //Console.WriteLine(res);
            //int n=int.Parse(Console.ReadLine());

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0 || i ==2)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if(j== 0 || j == n - 1)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //while (true)
            //{
            //    var x = Console.ReadLine().Split();
            //    var y = Console.ReadLine().Split();
            //    Console.WriteLine(Checker(x, y));
            //    var res=Console.ReadLine();
            //    if (res == "y")
            //    {
            //        continue;
            //    }
            //    else if (res == "n")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Please enter numbers:");
            //var n=int.Parse(Console.ReadLine());
            //var m = int.Parse(Console.ReadLine());
            //var c = int.Parse(Console.ReadLine());
            //var res=Combination(n, m, c);
            //Console.WriteLine("The result is:");
            //Console.WriteLine(res.Item1+" "+res.Item2);

            #endregion
            #region Elave
            //int num = int.Parse(Console.ReadLine());
            //var res = num.ToString().ToCharArray().OrderBy(x => x);
            //Console.WriteLine(int.Parse(new string(res)));
            #endregion
            List<string> strings= new List<string>()
            {
                "Murad",
                "Seda",
                "Zulfuqar",
                "Eltac"
            };
            IList<string> list = new List<string>()
            {
                "Murad",
                "Seda",
                "Zulfuqar",
                "Eltac"
            };
            
            Console.WriteLine(list);
            Console.WriteLine(strings);

            Console.ReadLine();
        }
    }
}

