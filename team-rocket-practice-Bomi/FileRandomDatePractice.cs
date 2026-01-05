using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace team_rocket_practice_Bomi
{
    internal class FileRandomDatePractice
    {
        public static void Menu()
        {
            while (true)
            {
                int q = Menus.KeyboardMenu(
                    new[]
                    {
                    "7-1-1：寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。",
                    "7-1-2：讀取1.txt 顯示在畫面上。",
                    "ex7-1-1：寫入九九乘法表資料到一個自己指定的文字檔。",
                    "ex7-1-2：讀取1.txt顯示在畫面上，並將阿拉伯數字轉換成中文數字，儲存到指定的路徑。",
                    "ex7-1-3：讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，儲存到指定的HTML檔裡。",
                    "7-2-1：請隨機由0~99產生一個數字輸出",
                    "7-2-1：請隨機由0~99產生10個數字輸出",
                    "7-2-3：隨機幫每位學員產生成績，並寫入文字檔",
                    "ex7-2-1：樂透開獎程式。",
                    "ex7-2-2：請在文字檔裡輸入午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。",
                    "ex7-2-3：讀取文字檔，隨機抽出值日生，直到全部學員都被抽過後，才可以再被抽。",
                    "回主選單"
                    },
                    "File, Random, Date Practice（CH 7）"
                );

                switch (q)
                {
                    case 0: Q7_1_1(); break;
                    case 1: Q7_1_2(); break;
                    case 2: ex7_1_1(); break;
                    case 3: ex7_1_2(); break;
                    case 4: ex7_1_3(); break;
                    case 5: Q7_2_1(); break;
                    case 6: Q7_2_2(); break;
                    case 7: Q7_2_3(); break;
                    case 8: ex7_2_1(); break;
                    case 9: ex7_2_2(); break;
                    case 10: ex7_2_3(); break;
                    default: return; // 回主選單
                }
            }
        }



        //7-1-1:寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
        static void Q7_1_1()
        {
            File.WriteAllText("歌詞.txt", "想守護你所有\r\n回應你包容的溫柔\r\n想用盡一生 陪在你左右是我\r\n曙光和暮暉的夢\r\n短暫如煙火在懷裡墜落\r\n奔向了星空 到不了心中\r\n有什麼理由必須要我放手?\r\n誰要我們的心遙遠得像太陽與地球?\r\n怎會走到最後 你愛著我卻不屬於我\r\n誰要時間奔走? 只能照耀 再不能觸碰\r\n最靠近的我們 怎麼 繞著 繞著 就錯過?\r\n在偌大銀河中\r\n沒想過像流星交錯\r\n該怎麼原諒? 讓你哭的人是我\r\n抱歉沒有機會說\r\n最渴望的夢是你在等我\r\n轟烈在星空 消散在心中\r\n最難忘的人是永恆地錯過\r\n誰要我們的心遙遠得像太陽與地球?\r\n怎麼走到最後? 你愛著我卻不屬於我\r\n誰要時間奔走? 只能照耀 再不能觸碰\r\n最靠近的我們 怎麼 繞著 繞著 各自走?\r\n人總要狠狠痛過才懂我要什麼\r\n捨不得 你不再快樂\r\n如果悲傷 請你留給我\r\n原來我們的心頑固地像太陽與地球\r\n以為徹底分開 徹底放手 不曾離開過\r\n我們只是錯過 誰都沒錯 都努力愛過\r\n最遙遠的我們 別回頭 往幸福一直走");
            Console.WriteLine("已寫出");
            Console.ReadKey();
        }




        //7-1-2:讀取1.txt 顯示在畫面上。
        static void Q7_1_2()
        {
            string txt = File.ReadAllText("1.txt");
            Console.WriteLine(txt);
            Console.ReadKey();
        }



        //ex7-1-1：寫入九九乘法表資料到一個自己指定的文字檔。
        static void ex7_1_1()
        {
            //File.WriteAllText("99.txt", "");
            //File.AppendAllText("99.txt", $"{"*",4}{1,4}{2,4}{3,4}{4,4}{5,4}{6,4}{7,4}{8,4}{9,4}\n");
            //for (int i = 1; i < 10; i++)
            //{
            //    File.AppendAllText("99.txt", $"{i,4}");
            //    for (int j = 1; j < 10; j++)
            //    {
            //        File.AppendAllText("99.txt", $"{i*j,4}");
            //    }
            //    File.AppendAllText("99.txt", $"\n");
            //}

            using (var sw = new StreamWriter("99.txt", false))
            {
                sw.Write($"{"*",4}");
                for (int i = 1; i < 10; i++)
                {
                    sw.Write($"{i,4}");
                }
                sw.WriteLine();

                for (int i = 1; i < 10; i++)
                {
                    sw.Write($"{i,4}");
                    for (int j = 1; j < 10; j++)
                    {
                        sw.Write($"{i * j,4}");
                    }
                    sw.WriteLine();
                }
            }
            Console.ReadKey();
        }




        //ex7-1-2：讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
        static void ex7_1_2()
        {
            string[] map = { "零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖" };
            string input = File.ReadAllText("1.txt");
            var sb = new StringBuilder();
            Console.WriteLine("=====原文=====");
            Console.WriteLine(input);

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    sb.Append($"{map[c - '0']}");
                }
                else
                {
                    sb.Append(c);
                }
            }

            string output = sb.ToString();
            Console.WriteLine("=====轉換後=====");
            Console.WriteLine(output);
            File.WriteAllText("1output.txt", output);
            Console.ReadKey();

        }





        //ex7-1-3：讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
        static void ex7_1_3()
        {
            string[] lines = File.ReadAllLines("fc4bb.csv");
            var sb = new StringBuilder();
            sb.AppendLine("=====原檔=====");
            for (int i = 0; i < lines.Length; i++)
            {
                sb.AppendLine(lines[i]);
            }
            Console.WriteLine(sb.ToString());
            sb.Clear();

            sb.AppendLine("<table>");
            for (int i = 0; i < lines.Length; i++)
            {
                sb.AppendLine("<tr>");
                string[] cols = lines[i].Split(',');
                foreach (string col in cols)
                {
                    if (i == 0)
                    {
                        sb.Append($"<th>{col}</th>");
                    }
                    else
                    {
                        sb.Append($"<td>{col}</td>");
                    }
                }
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</table>");

            Console.WriteLine(sb.ToString());
            File.WriteAllText("fc4bb.html", sb.ToString());
            Console.ReadKey();
        }





        //7-2-1：請隨機由0~99產生一個數字輸出
        static void Q7_2_1()
        {
            Random rom = new Random();
            int n = rom.Next(0, 100);
            Console.WriteLine(n);
            Console.ReadKey();
        }



        //7-2-2：請隨機由0~99產生10個數字輸出
        static void Q7_2_2()
        {
            Random rom = new Random();
            int n;
            for (int i = 0; i < 10; i++)
            {
                n = rom.Next(0, 100);
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }




        //7-2-3：隨機幫每位學員產生成績，並寫入文字檔
        static void Q7_2_3()
        {
            Random rom = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append($"學生{i},");
                sb.AppendLine(Convert.ToString(rom.Next(0, 101)));
            }
            Console.WriteLine(sb.ToString());
            File.WriteAllText("grade.txt", sb.ToString());
            Console.ReadKey();
        }




        //ex7-2-1：樂透開獎程式。
        static void ex7_2_1()
        {
            Random rom = new Random();
            var sb = new StringBuilder();
            int[] result = new int[6];
            for (int i = 0; i < 6; i++)
            {
                bool duplicate;
                do
                {
                    duplicate = false;
                    result[i] = rom.Next(1, 50);
                    for (int j = 0; j < i; j++)
                    {
                        if (result[i] == result[j])
                        {
                            duplicate = true;
                            break;
                        }
                    }
                } while (duplicate);
                sb.Append($"{result[i],4}");
            }
            Console.WriteLine("中獎號碼為：");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }




        //ex7-2-2：請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
        static void ex7_2_2()
        {
            string txt = File.ReadAllText("restaurants.txt");
            string[] restaurants = txt.Split(',');
            Random rom = new Random();
            while (true)
            {
                Console.WriteLine($"今天中午吃：{restaurants[rom.Next(0, restaurants.Length)]}");
                Console.WriteLine("按`R`以重抽");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.R)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }





        //ex7-2-3：讀取文字檔，隨機抽出值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
        static void ex7_2_3()
        {
            string[] names = File.ReadAllText("names.txt").Split(',');
            int[] check = new int[names.Length];
            int n;
            int pickcount = 0;
            Random rom = new Random();
            while (true)
            {
                n = rom.Next(0, names.Length);
                if (check[n] == 1)
                {
                    continue;
                }
                else
                {
                    check[n] = 1;
                    Console.WriteLine($"今天的值日生是：{names[n]}");
                    pickcount++;
                }
                if (pickcount == names.Length)
                {
                    Array.Clear(check, 0, check.Length);
                    pickcount = 0;
                    Console.WriteLine("輪完一輪了！");
                }
                Console.WriteLine("按`R`以重抽");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.R)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }

    }
}
