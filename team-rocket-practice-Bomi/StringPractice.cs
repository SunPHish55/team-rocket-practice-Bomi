using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_rocket_practice_Bomi
{
    internal class StringPractice
    {
        public static void Menu()
        {
            while (true)
            {
                int q = Menus.KeyboardMenu(
                    new[]
                    {
                    "6-1：輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。",
                    "6-2：請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。",
                    "6-3：輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。",
                    "6-4：輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。",
                    "6-5：輸入一個單字，若小於五個字元輸出長度不夠，反之則輸出前三個字。",
                    "6-6：輸入一段字，把我改成小明，如輸入我在唱歌，輸出小明在唱歌。",
                    "6-7：輸入一串字，顯示輸入幾個字。",
                    "ex6-1：連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。",
                    "ex6-2：字母波浪舞。",
                    "ex6-3：輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。",
                    "ex6-4：輸入的字，轉成HTML。",
                    "ex6-5：輸入5處數字，用空白隔開，輸出總和。",
                    "ex6-6：輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ。",
                    "回主選單"
                    },
                    "String Practice（CH 6）"
                );

                switch (q)
                {
                    case 0: Q6_1(); break;
                    case 1: Q6_2(); break;
                    case 2: Q6_3(); break;
                    case 3: Q6_4(); break;
                    case 4: Q6_5(); break;
                    case 5: Q6_6(); break;
                    case 6: Q6_7(); break;
                    case 7: ex6_1(); break;
                    case 8: ex6_2(); break;
                    case 9: ex6_3(); break;
                    case 10: ex6_4(); break;
                    case 11: ex6_5(); break;
                    case 12: ex6_6(); break;
                    default: return; // 回主選單
                }
            }
        }


        //6-1. 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
        static void Q6_1()
        {
            Console.Write("請輸入姓名：");
            string msg = ($"Hi~ {Console.ReadLine()}");
            Console.WriteLine($"{msg}");
            Console.ReadKey();
        }


        //6-2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
        static void Q6_2()
        {
            string check = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            Console.Write("請輸入任意一個字：");
            string input = Console.ReadLine();
            bool result = check.Contains(input);
            if( result == true)
            {
                Console.WriteLine("有這個字。");
            }
            else
            {
                Console.WriteLine("沒有這個字。");
            }
            Console.ReadKey();
        }



        //6-3. 輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
        static void Q6_3()
        {
            Console.WriteLine("請輸入一段字：");
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i > 0; i--)
            {
                input = input.Insert(i, "-");
            }
            Console.WriteLine($"{input}");
            Console.ReadKey();
        }


        //6-4. 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
        static void Q6_4() 
        {
            Console.WriteLine("請輸入一個檔名：");
            string fn = Console.ReadLine();
            string fn_ex = fn.Substring(fn.LastIndexOf(".") + 1);
            Console.WriteLine($"副檔名為：{fn_ex}");
            Console.ReadKey();
        }



        //6-5. 輸入一個單字，若小於五個字元輸出長度不夠，反之則輸出前三個字。
        static void Q6_5()
        {
            Console.WriteLine("請輸入一個單字：");
            string input = Console.ReadLine();
            if(input.Length < 5)
            {
                Console.WriteLine("長度不夠！");
            }
            else
            {
                Console.WriteLine(input.Substring(0, 3));
            }
            Console.ReadKey();
        }



        //6-6. 輸入一段字，把我改成小明，如輸入我在唱歌，輸出小明在唱歌。
        static void Q6_6()
        {
            Console.WriteLine("輸入一段字：");
            string input = Console.ReadLine();
            Console.WriteLine(input.Replace("我", "小明"));
            Console.ReadKey();
        }




        //6-7. 輸入一串字，顯示輸入幾個字。
        static void Q6_7()
        {
            Console.WriteLine("輸入一串字：");
            string input = Console.ReadLine();
            Console.WriteLine($"輸入了 {input.Length} 個字。");
            Console.ReadKey();
        }



        //ex6-1. 連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
        static void ex6_1()
        {
            string[] str = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"輸入第 {i + 1} 組字：");
                str[i] = Console.ReadLine();
                int check = 1;
                for (int j = 0; j < i; j++)
                {
                    check = str[i].CompareTo(str[j]);
                    if (check == 0)
                    {
                        break;
                    }
                }
                if (check == 0)
                {
                    Console.WriteLine("有輸入過");
                }
                else
                {
                    Console.WriteLine("沒輸入過");
                }
            }
            Console.ReadKey();
        }




        //ex6-2. 字母波浪舞。
        static void ex6_2()
        {
            Console.WriteLine("請輸入一串英文：");
            string input = Console.ReadLine();
            input = input.ToLower();
            char[] chars = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0) chars[i - 1] = char.ToLower(chars[i - 1]);
                chars[i] = char.ToUpper(chars[i]);
                Console.WriteLine(new string(chars));
            }
            Console.ReadKey();
        }




        //ex6-3. 輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
        static void ex6_3()
        {
            Console.WriteLine("請輸入時間(依 XX:XX 的格式)：");
            string[] time = Console.ReadLine().Split(':');
            Console.WriteLine($"{time[0]} 時 {time[1]} 分");
            Console.ReadKey();
        }



        //ex6-4. 輸入的字，轉成HTML。
        static void ex6_4()
        {
            Console.WriteLine("請輸入多個單字並用,分隔：");
            string[] ul = Console.ReadLine().Trim().Split(',');
            Console.WriteLine("<ul>");
            foreach (string li in ul)
            {
                Console.WriteLine($"    <li>{li.Trim()}<li>");
            }
            Console.WriteLine("</ul>");
            Console.ReadKey();
        }




        //ex6-5. 輸入5處數字，用空白隔開，輸出總和。
        static void ex6_5()
        {
            Console.WriteLine("請用空格間隔輸入5個數字：");
            string[] nums = Console.ReadLine().Split(' ');
            int sum = 0;
            foreach (string i in nums)
            {
                int n = int.Parse(i);
                sum += n;
            }
            Console.WriteLine($"sum = {sum}");
            Console.ReadKey();
        }




        //輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
        static void ex6_6()
        {
            Console.WriteLine("請輸入一段文字：");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            for (int i = chars.Length - 1 ; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }
            Console.ReadKey();
        }
    }
}
