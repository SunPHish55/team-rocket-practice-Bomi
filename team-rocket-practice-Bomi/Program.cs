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





            /*
             C#的變數型態、預設值、長度、值的範圍
            變數型態    預設值     長度      值的範圍
            sbyte       0          8bits     -128 ~ 127
            short       0          16bits    -32768 ~ 32767
            int         0          32bits    -2,147,483,648 ~ 2,147,483,647
            long        0          64bits    -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
            (以上整數都有無號版)

            float       0.0f       32bits    正負1.5*10^-45 ~ 正負 3.4*10^38
            double      0.0        64bits    正負5.0*10^-324 ~ 正負 1.7*10^308
            decimal     0.0m       128bits   正負7.9*10^28

            char        '\0'       2bytes    Unicode（0~65535）
            string      null       參考型別(8bytes)
            bool        false      1bytes    true/false
            
            array       陣列
             */





            /*
            變數宣告的方法

            宣告變數：
            變數種類 變數名稱;
            如：
            int a;
            即可宣告一個名為a的整數變數

            同時宣告多變數：
            用,分隔多變數即可
            如：
            int a, b, c;
            就宣告了 a, b, c 三個整數變數
            str s1, s2;
            宣告了 s1, s2 兩個整數變數

            宣告變數時，同時指定變數初始值：
            宣告變數時在名稱後接 = 數值 即可
            如：
            int a = 10;
            int b = 5, c = 10;
            str s1 = "像這樣", s2 = "就可以", s3 = "一次宣告多字串";
            須注意就算多變數的數值相同也需要分別賦值
             */






            /*
            說明型別之間如何轉換
            | 方法                   | 使用情境                  |
            | --------------------   | ---------------------     |
            | 隱式轉換               | 安全、範圍擴大（int → double） |
            如：
            int a = 10;
            double d = a;
            直接將不同型別的變數塞進另一個變數裡

            | 顯式轉換               | 可能遺失精度（double → int）   |
            如：
            double d = 3.14;
            int a = (int)d;
            須加上額外指令指名要將不同型別的變數塞進另一個變數裡，可能會遺失資料，
            如範例中d原本是3.14，轉換成int塞進a後剩下3而已

            | Convert 類別           | 常用於字串與其他型別            |
            如：
            str s1 = "123", s2 = "123.123"
            Convert.ToInt32(s1);
            Convert.ToIntDouble(s2);
            會依照一定規則轉換，例如小數部分不是直接捨去而是四捨五入

            | Parse / TryParse       | 使用者輸入、字串轉數字最佳選擇  |
            如：
            Parse：
            int n = int.Parse("123");       // 123
            double d = double.Parse("3.14"); // 3.14
            bool flag = bool.Parse("true");  // true

            只能輸入 string 轉換，如果格式錯誤會拋例外
            int n = int.Parse("abc");   // 例外：FormatException

            TryParse：
            更安全的轉換方式，可以避免被拋例外
            int value;
            bool ok = int.TryParse("123", out value);
            if (ok)
            {
                Console.WriteLine(value); // 123
            }
            else
            {
                Console.WriteLine("轉換失敗");
            }
             */





            /*
            查詢各種運算符、用法、優先級，並整理成表格。
            優先級由上排到下，常用的運算符如下：
             ++x, x++...等               一元運算子，先對x做+1後使用，或使用後做+1
             *, /, %                     乘、除、餘數
             +, -                        加、減
             <, >, <=, >=, is, as        關係與型別判斷
             ==, !=                      相等、不等
             &&                          邏輯AND
             ||                          邏輯OR
             =, +=, -=, *=...等          指派(+=系列：x += 10; x = x + 10 的意思)
             */






            ////2-1. 寫一程式，輸入x和y，如果x>=y，則列印x，否則列印y
            //double x, y;
            //Console.WriteLine("請依序輸入 x, y 兩數");
            //x = Convert.ToDouble(Console.ReadLine());
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"x = {x}, y = {y}");

            //if ( x >= y) { Console.WriteLine("x"); }
            //else { Console.WriteLine("y"); }


        }
    }
}
