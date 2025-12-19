using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_rocket_practice_Bomi
{
    internal class LoopPractice
    {
        public static void Run()
        {

            //////3-1.寫一程式，輸入10個整數，求其最小值。
            //int n, min = int.MaxValue;
            //Console.WriteLine("Please enter 10 integers:");
            //for (int i = 0; i < 10; i++)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n < min)
            //    {
            //        min = n;
            //    }
            //}
            //Console.WriteLine($"The minimal interger is {min}");
            //Console.ReadKey();





            ////3-2.寫一程式，輸入N個整數，求其最小值。
            //int n, num, min = int.MaxValue;
            //Console.WriteLine("Please enter N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Please enter {n} integers:");
            //for (int i = 0; i < n; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine($"The minimal interger is {min}");
            //Console.ReadKey();





            ////3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字。
            //int n;
            //List<int> values = new List<int>();
            //Console.WriteLine("Please enter 10 integers:");
            //for (int i = 0; i < 10; i++)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n > 12)
            //    {
            //        values.Add(n);
            //    }
            //}
            //Console.WriteLine(string.Join(", ", values));
            //Console.ReadKey();






            ////3-4. 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。
            //int n, sum = 0;
            //List<int> values = new List<int>();
            //Console.WriteLine("Please enter 10 integers:");
            //for (int i = 0; i < 10; i++)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n > 12)
            //    {
            //        values.Add(n);
            //    }
            //}
            //foreach(int v in values)
            //{
            //    sum += v;
            //}
            //Console.WriteLine($"sun = {sum}");
            //Console.ReadKey();







            ////3-5. 寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。
            //int n, num, max = int.MinValue;
            //List<int> odds = new List<int>();
            //Console.WriteLine("Please enter N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Please enter {n} integers:");
            //for (int i = 0; i < n; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num % 2 == 1)
            //    {
            //        odds.Add(num);
            //    }
            //}
            //foreach( int odd in odds)
            //{
            //    if (odd > max)
            //    {
            //        max = odd;
            //    }
            //}
            //Console.WriteLine($"The max odd is {max}");
            //Console.ReadKey();






            ////3-6. 寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到
            ////12 + (-2)2 + 32 + (-4)2 + 52 = 1 + 9 + 25 = 35
            //int n, num, sum = 0;
            //List<int> positives = new List<int>();
            //Console.WriteLine("Please enter N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Please enter {n} integers:");
            //for (int i = 0; i < n; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        positives.Add(num);
            //    }
            //}
            //foreach (int positive in positives)
            //{
            //    sum += positive * positive;
            //}
            //Console.WriteLine($"The sum of positive numbers is {sum}");
            //Console.ReadKey();







            ////3-7. 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。
            //int n, num;
            //List<int> positives = new List<int>();
            //Console.WriteLine("Please enter N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Please enter {n} integers:");
            //for (int i = 0; i < n; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if(num < 0)
            //    {
            //        positives.Add(-num);
            //    }
            //    else
            //    {
            //        positives.Add(num);
            //    }
            //}
            //Console.WriteLine("The absolute of each numbers are:");
            //foreach (int positive in positives)
            //{
            //    Console.Write($"{positive}, ");
            //}
            //Console.ReadKey();
        }
    }
}
