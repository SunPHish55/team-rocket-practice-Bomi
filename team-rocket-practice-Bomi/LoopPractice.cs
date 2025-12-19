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






            //3-4. 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。
            int n, sum = 0;
            List<int> values = new List<int>();
            Console.WriteLine("Please enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 12)
                {
                    values.Add(n);
                }
            }
            foreach(int v in values)
            {
                sum += v;
            }
            Console.WriteLine($"sun = {sum}");
            Console.ReadKey();
        }
    }
}
