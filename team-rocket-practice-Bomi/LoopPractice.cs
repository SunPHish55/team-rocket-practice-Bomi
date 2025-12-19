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





            ////補充習題3-1.判斷101-200之間有多少個質數，並輸出所有質數。
            //List<int> primes = new List<int>();
            //for(int i = 101; i < 201; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j*j <= i; j++)
            //    {
            //        if( i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if( isPrime == true)
            //    {
            //        primes.Add(i);
            //    }
            //}
            //Console.WriteLine("Primes in 101~200 are: ");
            //foreach(int prime in primes)
            //{
            //    Console.Write($"{prime}, ");
            //}
            //Console.ReadKey();






            ////補充習題3-1. 找101~200質數，While版
            //List<int> primes = new List<int>();
            //int i = 101;
            //while ( i < 201 )
            //{
            //    bool isPrime = true;
            //    int j = 2;
            //    while ( j * j <= i)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //        j++;
            //    }
            //    if (isPrime == true)
            //    {
            //        primes.Add(i);
            //    }
            //    i++;
            //}
            //Console.WriteLine("Primes in 101~200 are: ");
            //foreach (int prime in primes)
            //{
            //    Console.Write($"{prime}, ");
            //}
            //Console.ReadKey();






            ////補充習題3-2. 輸入一個數，輸出其質因數
            //List<int> primes = new List<int>();
            //List<int> pfactors = new List<int>();
            //int n;
            //Console.WriteLine("Please enter a integer N : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i < n; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime == true)
            //    {
            //        primes.Add(i);
            //        if( n % i == 0)
            //        {
            //            pfactors.Add(i);
            //        }
            //    }
            //}
            //Console.WriteLine("Prime factors of N are: ");
            //foreach (int pfactor in pfactors)
            //{
            //    Console.Write($"{pfactor}, ");
            //}
            //Console.ReadKey();







            ////補充習題3-2. 找質因數，while版
            //List<int> primes = new List<int>();
            //List<int> pfactors = new List<int>();
            //int n;
            //Console.WriteLine("Please enter a integer N : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //int i = 2;
            //while ( i < n )
            //{
            //    bool isPrime = true;
            //    int j = 2;
            //    while ( j * j <= i)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //        j++;
            //    }
            //    if (isPrime == true)
            //    {
            //        primes.Add(i);
            //        if (n % i == 0)
            //        {
            //            pfactors.Add(i);
            //        }
            //    }
            //    i++;
            //}
            //Console.WriteLine("Prime factors of N are: ");
            //foreach (int pfactor in pfactors)
            //{
            //    Console.Write($"{pfactor}, ");
            //}
            //Console.ReadKey();






            ////補充習題3-3. 求100到300中可以被3與7整除的個數。
            //int m = 0;
            //for (int i = 100; i < 301; i++)
            //{
            //    if(i % 21 == 0)
            //    {
            //        m++;
            //    }
            //}
            //Console.WriteLine(" Amount of multiples of 3 & 7 in 100~300 are: ");
            //Console.WriteLine($"{m}");
            //Console.ReadKey();







            ////補充習題3-3. 求100到300中可以被3與7整除的個數，while版
            //int m = 0;
            //int i = 100;
            //while ( i < 301 )
            //{
            //    if (i % 21 == 0)
            //    {
            //        m++;
            //    }
            //    i++;
            //}
            //Console.WriteLine("Amount of multiples of 3 & 7 in 100~300 are: ");
            //Console.WriteLine($"{m}");
            //Console.ReadKey();
        }
    }
}
