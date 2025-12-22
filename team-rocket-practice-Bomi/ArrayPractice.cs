using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_rocket_practice_Bomi
{
    internal class ArrayPractice
    {
        public static void Run()
        {
            ////5-1. 寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5。
            //int[] values = new int[10];
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個數字：");
            //    values[i] = Convert.ToInt32(Console.ReadLine());
            //    if (values[i] > 5)
            //    {
            //        values[i] -= 5;
            //    }
            //    else
            //    {
            //        values[i] += 5;
            //    }
            //}
            //Console.WriteLine("結果為：");
            //foreach (int v in values)
            //{
            //    Console.Write($"{v,4}");
            //}
            //Console.ReadKey();






            ////5-2. 寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i。
            //int[] values = new int[10];
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個數字：");
            //    values[i] = Convert.ToInt32(Console.ReadLine());
            //    values[i] += i;
            //}
            //Console.WriteLine("結果為：");
            //foreach (int v in values)
            //{
            //    Console.Write($"{v,4}");
            //}
            //Console.ReadKey();






            ////5-3. 寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0。
            //int[] a = new int[10];
            //int[] b = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個數字：");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //    if (a[i] >= 0) 
            //    {
            //        b[i] = 1;
            //    }
            //    else
            //    {
            //        b[i] = 0;
            //    }
            //}
            //Console.WriteLine("a：");
            //foreach (int x in a)
            //{
            //    Console.Write($"{x}, ");
            //}
            //Console.WriteLine("\nb：");
            //foreach (int y in b)
            //{
            //    Console.Write($"{y}, ");
            //}
            //Console.ReadKey();






            ////5-4. 寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。
            //int[,] a = new int[3, 5];
            //int[] row_sum = new int[3] { 0, 0, 0 };
            //int[] column_sum = new int[5] { 0, 0, 0, 0, 0 };
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"請輸入row {i}, column {j} 的數字：");
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //        row_sum[i] += a[i, j];
            //        column_sum[j] += a[i, j];
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write($"{a[i, j], 4}");
            //    }
            //    Console.WriteLine($"| sum = {row_sum[i]}");
            //}
            //Console.WriteLine("---- column sum ----");
            //foreach (int s in column_sum)
            //{
            //    Console.Write($"{s,4}");
            //}
            //Console.ReadKey();






            ////5-5. 寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。
            //int[,] a = new int[3, 5];
            //int[] row_max = new int[3] { int.MinValue, int.MinValue, int.MinValue };
            //int[] column_max = new int[5] { int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue };
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"請輸入row {i}, column {j} 的數字：");
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //        if (a[i, j] > row_max[i])
            //        {
            //            row_max[i] = a[i, j];
            //        }
            //        if (a[i, j] > column_max[j])
            //        {
            //            column_max[j] = a[i, j];
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write($"{a[i, j], 4}");
            //    }
            //    Console.WriteLine($"|max = {row_max[i]}");
            //}
            //Console.WriteLine("----- column max -----");
            //foreach (int max in column_max)
            //{
            //    Console.Write($"{max, 4}");
            //}
            //Console.ReadKey();






            ////5-6. 寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5。
            //int[,] ab = new int[2, 5];
            //int[] sums = new int[5] { 0, 0, 0, 0, 0 };
            //for (int i = 0; i < ab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ab.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"請輸入row {i}, column {j} 的數：");
            //        ab[i, j] = Convert.ToInt32(Console.ReadLine());
            //        sums[j] += ab[i, j];
            //    }
            //}
            //for (int i = 0; i < ab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ab.GetLength(1); j++)
            //    {
            //        Console.Write($"{ab[i, j], 4}");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("----- ai + bi -----");
            //for (int i = 0; i < sums.GetLength(0); i++)
            //{
            //    Console.WriteLine($"a{i} + b {i} = {sums[i]}");
            //}
            //Console.ReadKey();





            ////5-7. 寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。
            ////令x為a中的最大值，令y為b中的最大值，求x與y中較小者。
            //int[,] ab = new int[2, 5];
            //int[] maxs = new int[2] { int.MinValue, int.MinValue };
            //for (int i = 0; i < ab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ab.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"請輸入row {i}, column {j} 的數：");
            //        ab[i, j] = Convert.ToInt32(Console.ReadLine());
            //        if (ab[i, j] > maxs[i])
            //        {
            //            maxs[i] = ab[i, j];
            //        }
            //    }
            //}
            //for (int i = 0; i < ab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ab.GetLength(1); j++)
            //    {
            //        Console.Write($"{ab[i, j],4}");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("   x   y");
            //foreach (int max in maxs)
            //{
            //    Console.Write($"{max,4}");
            //}
            //Console.WriteLine($"\n{maxs.Min()}比較小");
            //Console.ReadKey();

        }
    }
}
