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
                    "回主選單"
                    },
                    "Array Practice（CH 5）"
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

    }
}
