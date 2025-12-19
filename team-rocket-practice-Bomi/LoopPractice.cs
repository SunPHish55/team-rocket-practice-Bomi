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







            ////4-1. 利用while寫一程式求N個數字的最大值。
            //Console.WriteLine("Please enter N:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Please enter {n} numbers:");
            //double num, max = double.MinValue;
            //int i = 0;
            //while (i < n)
            //{
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if(num > max)
            //    {
            //        max = num;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"The maximun number is : {max}");
            //Console.ReadKey();







            ////4-2. 利用while寫一程式求一個等差級數數字的和，
            ////一共有N個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個 的總和)
            //int n, a1, d, sum = 0;
            //Console.WriteLine("Please enter the number of terms(n):");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the start of arithmetic series(a1):");
            //a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the common difference(d):");
            //d = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while( i < n)
            //{
            //    Console.WriteLine($"a{i + 1} = {a1}");
            //    sum += a1;
            //    a1 += d;
            //    i++;
            //}
            //Console.WriteLine($"sum = {sum}");
            //Console.ReadKey();







            ////4-3. 利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。
            //int n, num, sum = 0;
            //List<int> values = new List<int>();
            //Console.WriteLine("Please enter N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter N numbers:");
            //int i = 0;
            //while( i < n )
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if(num < 13)
            //    {
            //        values.Add(num);
            //        sum += num;
            //    }
            //    i++;
            //}
            //Console.WriteLine("Numbers less than 13:");
            //foreach(int v in values)
            //{
            //    Console.Write($"{v}, ");
            //}
            //Console.WriteLine($"\nsum = {sum}");
            //Console.ReadKey();







            ////4-4. 利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。
            //int n, num = 0;
            //Console.WriteLine("Please enter N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter N numbers:");
            //int i = 0;
            //bool founded = false;
            //while (i < n)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if(num > 7 && num < 10)
            //    {
            //        founded = true;
            //        break;
            //    }
            //    i++;
            //}
            //if (founded == true)
            //{
            //    Console.WriteLine($"7 < {num} < 10 ");
            //}
            //else
            //{
            //    Console.WriteLine("There is no number between 7 and 10.");
            //}
            //Console.ReadKey();






            ////4-5. 利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi。
            //int a = 0, b = 0;
            //bool founded = false;
            //int i = 1;
            //while(i <= 5)
            //{
            //    Console.Write($"a{i} = ");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"b{i} = ");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if(a > b)
            //    {
            //        founded = true;
            //        break;
            //    }
            //    i++;
            //}
            //if (founded == true)
            //{
            //    Console.WriteLine($"Founded : a{i} = {a}, b{i} = {b}");
            //}
            //else
            //{
            //    Console.WriteLine("Every b is larger than a.");
            //}
            //Console.ReadKey();






            ////補充習題4-1. Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，
            ////因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
            ////假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
            //int time, burger = 0, cost = 0;
            //Console.WriteLine("Please enter time(minutes):");
            //time = Convert.ToInt32(Console.ReadLine());
            //while(time >= 5)
            //{
            //    burger++;
            //    cost += 39;
            //    time -= 5;
            //}
            //Console.WriteLine($"吃掉的漢堡：{burger} 個");
            //Console.WriteLine($"花掉的錢：{cost} 元");
            //Console.WriteLine($"還剩 {time} 分鐘");
            //Console.ReadKey();






            ////補充習題4-2. 小明貸款買房花560萬，每個月可還4萬，
            ////每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。
            //int debt = 560, month = 0;
            //while(debt > 0)
            //{
            //    debt -= 4;
            //    month++;
            //    if(month % 12 == 0)
            //    {
            //        debt -= 1;
            //    }
            //    //Console.WriteLine($"目前欠款：{debt}");
            //}
            //Console.WriteLine($"花了 {month} 個月，終於還完了！");
            //Console.ReadKey();






            ////補充習題4-3. 系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！
            ////猜錯時，要提示是比較大還是比較小。
            //int ans, n;
            //Random rnd = new Random();
            //ans = rnd.Next(-1000, 1000);
            //do
            //{
            //    Console.WriteLine("Guess a number:");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n - ans > 0)
            //    {
            //        Console.WriteLine("Smaller!");
            //    }
            //    else if (n - ans < 0)
            //    {
            //        Console.WriteLine("Larger!");
            //    }
            //} while (n != ans);
            //Console.WriteLine($"Bingo! The answer is {ans}.");
            //Console.ReadKey();


        }
    }
}
