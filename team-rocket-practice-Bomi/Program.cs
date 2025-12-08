using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_rocket_practice_Bomi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1-1.寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×2。
            //double a, b, c, d, result;
            //Console.WriteLine("請依序輸入 a, b, c, d 4個數：");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //c = Convert.ToDouble(Console.ReadLine());
            //d = Convert.ToDouble(Console.ReadLine());
            //if (c - d == 0)
            //{
            //    Console.WriteLine("Error! Denominator can't be 0!");
            //}
            //else
            //{
            //    result = ((a + b) / (c - d)) * 2;
            //    Console.WriteLine($"( ({a} + {b}) / ({c} - {d}) ) × 2");
            //    Console.WriteLine($" = ( {a + b} / {c - d} ) × 2");
            //    Console.WriteLine(" = " + result);
            //    Console.WriteLine("Result = " + result);
            //}







            ////1-2. 二元一次方程式公式解
            //double a1, a2, b1, b2, c1, c2;
            //double D, sol_x, sol_y;
            //Console.WriteLine("請依照步驟輸入二元一次方程式 / a1 x + b1 y = c1");
            //Console.WriteLine("                             / a2 x + b2 y = c2");

            ////輸入二元一次方程式
            ////輸入第一個式子
            //Console.WriteLine("a1 = ");
            //a1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("b1 = ");
            //b1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("c1 = ");
            //c1 = Convert.ToDouble(Console.ReadLine());
            ////輸入第二個式子
            //Console.WriteLine("a2 = ");
            //a2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("b2 = ");
            //b2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("c2 = ");
            //c2 = Convert.ToDouble(Console.ReadLine());

            //D = a1 * b2 - a2 * b1; //判別式
            //if( D == 0)
            //{
            //    if(a1 * c2 == a2 * c1)//比較係數判斷無解還是無限多組解
            //    {
            //        Console.WriteLine("無限多組解");
            //    }
            //    else { Console.WriteLine("無解"); }
            //}
            ////解
            //else
            //{
            //    sol_x = (c1 * b2 - c2 * b1) / D;
            //    sol_y = (c1 * a2 - c2 * a1) / -D;
            //    Console.WriteLine($"x = {sol_x}, y = {sol_y}");
            //}





            ////1-3. 輸入a和b，求：( a^2 + b^2 ) / ( a^2 - b^2 )
            //double a, b, y;
            //Console.WriteLine("請依序輸入 a, b 兩數：");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());

            //if( Math.Pow( a, 2) - Math.Pow( b, 2) == 0)
            //{
            //    Console.WriteLine("Error! Denominator can't be 0!");
            //}
            //else
            //{
            //    y = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
            //    Console.WriteLine("y = " + y);
            //}






            ////1-4. 輸入a和b，求：y = sqrt( a^2 + b^2 )
            //double a, b, y;
            //Console.WriteLine("請依序輸入 a, b 兩數：");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());

            //y = Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2) );
            //Console.WriteLine("y = " + y);







            ////1-5. 輸入a、b和c，求：y = a - (b + c)(3a - c)
            //double a, b, c, y;
            //Console.WriteLine(" y = a - (b + c)(3a - c) ");
            //Console.WriteLine("請依序輸入 a, b, c 三數：");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //c = Convert.ToDouble(Console.ReadLine());

            //y = a - (b + c) * (3 * a - c);
            //Console.WriteLine("y = " + y);






            ////1-6. 請隨意輸入正負數，取絕對值輸出
            //Console.WriteLine("請隨意輸入正負數，將會取絕對值後輸出：");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("絕對值 = " + ( Math.Abs(a) ));





            ////1-7. 輸入的西元年份轉換成民國年份後輸出
            //int ROCera, AD;
            //Console.WriteLine("請輸入西元年份 ：");
            //AD = Convert.ToInt32(Console.ReadLine());
            //if( AD < 1912) { Console.WriteLine("還沒有民國呢"); }
            //else
            //{
            //    ROCera = AD - 1911;
            //    Console.WriteLine($"西元 {AD} 年 = 民國 {ROCera} 年");
            //}






            ////1-8. 請輸入身高體重，輸出BMI
            //double height, weight, BMI;
            //Console.WriteLine("BMI計算器");
            //Console.WriteLine("請輸入身高(cm)：");
            //height = Convert.ToDouble(Console.ReadLine());
            //height = height / 100;
            //Console.WriteLine("請輸入體重(kg)：");
            //weight = Convert.ToDouble(Console.ReadLine());
            //if (height < 0 || weight < 0 || height >5 || weight > 500){
            //    Console.WriteLine("請輸入有效數字！");
            //}
            //else {
            //    BMI = weight / Math.Pow(height, 2);
            //    Console.WriteLine($"BMI 為：{BMI:F2}");
            //}
        }
    }
}
