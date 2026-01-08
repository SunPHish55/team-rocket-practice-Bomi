using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace team_rocket_practice_Bomi
{
    internal class FunctionPractice
    {
        public static void Menu()
        {
            while (true)
            {
                int q = Menus.KeyboardMenu(
                    new[]
                    {
                    "題目一 : 寫一個function 可以把一般對話框的文字轉成HTML。",
                    "題目二 : 寫一個function，回傳輸入的值是否數字。",
                    "題目三 : 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式",
                    "題目四 : 寫一個function，回傳輸入的值是否符合手機格式。",
                    "題目五 : 寫一個function，回傳輸入的值是否符合身分證字號格式。",
                    "題目六 : 寫一個function，若輸入的文字大於Ｎ個，則超過的字變成點點點。",
                    "題目七： 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式。",
                    "題目八 : 寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式。",
                    "題目九 : 寫一個function，回傳輸入的年是否閏年。",
                    "題目十 : 寫一個function，輸入手機號碼，回傳今天運勢",
                    "回主選單"
                    },
                    "Function Practice"
                );

                switch (q)
                {
                    case 0: Q1(); break;
                    case 1: Q2(); break;
                    case 2: Q3(); break;
                    case 3: Q4(); break;
                    case 4: Q5(); break;
                    case 5: Q6(); break;
                    case 6: Q7(); break;
                    case 7: Q8(); break;
                    case 8: Q9(); break;
                    case 9: Q10(); break;
                    default: return; // 回主選單
                }
            }
        }

        //題目一 : 寫一個function 可以把一般對話框的文字轉成HTML。
        static void Q1()
        {
            string input, output;
            Console.WriteLine("請輸入要轉換的文字（格式：xxx,xxx,xxx）：");
            input = Console.ReadLine();
            output = TransformToHTML(input);
            Console.WriteLine(output);
            Console.ReadKey();
        }
        public static string TransformToHTML(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] strings = s.Split(',');
            sb.AppendLine("<ul>");
            for (int i = 0; i < strings.Length; i++)
            {
                sb.AppendLine($"    <li>{strings[i]}</li>");
            }
            sb.AppendLine("</ul>");
            return sb.ToString();
        }



        //題目二 : 寫一個function，回傳輸入的值是否數字。
        static void Q2()
        {
            string input;
            Console.WriteLine("請輸入一串文字：");
            input = Console.ReadLine();
            IsNumber(input);
            Console.ReadKey();
        }
        public static void IsNumber(string s)
        {
            bool isNum = int.TryParse(s, out _);
            if (isNum)
            {
                Console.WriteLine("輸入的是數字。");
            }
            else
            {
                Console.WriteLine("輸入的不是數字。");
            }
        }


        //題目三 : 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        static void Q3()
        {
            string input;
            Console.WriteLine("請輸入E - mail：");
            input = Console.ReadLine();
            IsEmail(input);
            Console.ReadKey();
        }
        public static void IsEmail(string s)
        {
            Regex emailReg = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (emailReg.IsMatch(s))
            {
                Console.WriteLine("符合E - mail格式");
            }
            else
            {
                Console.WriteLine("不符合E - mail格式");
            }
        }



        //題目四 : 寫一個function，回傳輸入的值是否符合手機格式。
        static void Q4()
        {
            string input;
            Console.WriteLine("請輸入手機：");
            input = Console.ReadLine();
            IsPNum(input);
            Console.ReadKey();
        }
        public static void IsPNum(string s)
        {
            Regex phoneReg = new Regex(@"^09\d{8}$");
            if (phoneReg.IsMatch(s))
            {
                Console.WriteLine("符合手機格式");
            }
            else
            {
                Console.WriteLine("不符合手機格式");
            }
        }



        //題目五 : 寫一個function，回傳輸入的值是否符合身分證字號格式。
        static void Q5()
        {
            string input;
            Console.WriteLine("請輸入身分證字號：");
            input = Console.ReadLine();
            IsID(input);
            Console.ReadKey();
        }
        public static void IsID(string s)
        {
            Regex IDReg = new Regex(@"^[A-Z][12]\d{8}$");
            if (IDReg.IsMatch(s))
            {
                Console.WriteLine("符合身分證字號格式");
            }
            else
            {
                Console.WriteLine("不符合身分證字號格式");
            }
        }



        //題目六 : 寫一個function，若輸入的文字大於Ｎ個，則超過的字變成點點點。
        static void Q6()
        {
            string input;
            int n;
            Console.WriteLine("請輸入最大字數N：");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("請輸入一段文字：");
            input = Console.ReadLine();
            Ellip(input, n);
            Console.ReadKey();
        }
        public static void Ellip(string s, int n)
        {
            if (s.Length > n)
            {
                Console.WriteLine($"{s.Substring(0, n)}...");
            }
            else
            {
                Console.WriteLine(s);
            }
        }



        //題目七： 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式。
        static void Q7()
        {
            string input;
            Console.WriteLine("請輸入一個日期（格式：yyyy-MM-dd）：");
            input = Console.ReadLine();
            ToDate(input);
            Console.ReadKey();
        }
        public static void ToDate(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            if (dt.Year < 1911)
            {
                Console.WriteLine("還沒有民國");
            }
            else
            {
                Console.WriteLine($"該日期為民國{dt.Year - 1911}年{dt.Month}月{dt.Day}日");
            }
        }



        //題目八 : 寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式。
        static void Q8()
        {
            string input;
            Console.WriteLine("請輸入一個日期（格式：yyyy-MM-dd）：");
            input = Console.ReadLine();
            ToDayInWeek(input);
            Console.ReadKey();
        }
        public static void ToDayInWeek(string s)
        {
            string[] weekday = {"星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            DateTime dt = Convert.ToDateTime(s);
            if (dt.Year < 1911)
            {
                Console.WriteLine("還沒有民國");
            }
            else
            {
                Console.WriteLine($"該日期為民國{dt.Year - 1911}年{dt.Month}月{dt.Day}日 {weekday[(int)dt.DayOfWeek]}");
            }
        }



        //題目九 : 寫一個function，回傳輸入的年是否閏年。
        static void Q9()
        {
            string input;
            Console.WriteLine("請輸入一個年份（西元）：");
            input = Console.ReadLine();
            IsLeap(input);
            Console.ReadKey();
        }
        public static void IsLeap(string s)
        {
            bool isLeap = DateTime.IsLeapYear(int.Parse(s));
            if (isLeap)
            {
                Console.WriteLine("是閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }
        }




        //題目十 : 寫一個function，輸入手機號碼，回傳今天運勢
        static void Q10()
        {
            string input;
            Console.WriteLine("請輸入手機號碼：");
            input = Console.ReadLine();
            PhoneLuck(input);
            Console.ReadKey();
        }
        public static void PhoneLuck(string s)
        {
            Regex phoneReg = new Regex(@"^09\d{8}$");
            while (!phoneReg.IsMatch(s))
            {
                Console.WriteLine("不是手機號碼，請輸入手機號碼：");
                s = Console.ReadLine();
            }
            int luckNum = int.Parse(s.Substring(6));
            luckNum = luckNum % 80;
            switch (luckNum) {
                case 1: Console.WriteLine("大展鴻圖．可獲成功  吉"); break;
                case 2: Console.WriteLine("一盛一衰．勞而無功  凶­"); break;
                case 3: Console.WriteLine("蒸蒸日上．百事順遂　吉"); break;
                case 4: Console.WriteLine("坎坷前途．苦難折磨　凶"); break;
                case 5: Console.WriteLine("生意欣榮．名利雙收　吉"); break;
                case 6: Console.WriteLine("天降幸運．可成大功　吉"); break;
                case 7: Console.WriteLine("和氣致祥．必獲成功　吉"); break;
                case 8: Console.WriteLine("貫徹志望．成功可期　吉"); break;
                case 9: Console.WriteLine("獨營無力．財利無望　凶"); break;
                case 10: Console.WriteLine("空費心力．徒勞無功　凶"); break;

                case 11: Console.WriteLine("穩健著實．必得人望　吉"); break;
                case 12: Console.WriteLine("薄弱無力．謀事難成　凶"); break;
                case 13: Console.WriteLine("天賦吉運．能得人望　吉"); break;
                case 14: Console.WriteLine("是成是敗．惟靠堅毅　凶"); break;
                case 15: Console.WriteLine("大事成就．一定興隆　吉"); break;
                case 16: Console.WriteLine("成就大業．名利雙收　吉"); break;
                case 17: Console.WriteLine("有貴人助．可得成功　吉"); break;
                case 18: Console.WriteLine("順利昌隆．百事亨通　吉"); break;
                case 19: Console.WriteLine("內外不合．障礙重重　凶"); break;
                case 20: Console.WriteLine("歷盡艱難．焦心憂勞　凶"); break;

                case 21: Console.WriteLine("專心經營．善用智慧　吉"); break;
                case 22: Console.WriteLine("懷才不遇．事不如意　凶"); break;
                case 23: Console.WriteLine("名顯四方．終成大業　吉"); break;
                case 24: Console.WriteLine("須靠自力．能奏大功　吉"); break;
                case 25: Console.WriteLine("天時地利．再得人格　吉"); break;
                case 26: Console.WriteLine("波瀾起伏．凌駕萬難　凶"); break;
                case 27: Console.WriteLine("一盛一衰．可守成功　凶帶吉"); break;
                case 28: Console.WriteLine("遇衰轉吉．遇厄轉好　吉"); break;
                case 29: Console.WriteLine("青雲直上．才略奏功　吉"); break;
                case 30: Console.WriteLine("吉凶參半．得失相伴　凶"); break;

                case 31: Console.WriteLine("名利雙收．大業成就　吉"); break;
                case 32: Console.WriteLine("池中之龍．成功可望　吉"); break;
                case 33: Console.WriteLine("智慧慎始．必可昌隆　吉"); break;
                case 34: Console.WriteLine("災難不絕．難望成功　凶"); break;
                case 35: Console.WriteLine("中吉之數．進退保守　吉"); break;
                case 36: Console.WriteLine("波瀾重疊．常陷窮困　凶"); break;
                case 37: Console.WriteLine("逢凶化吉．風調雨順　吉"); break;
                case 38: Console.WriteLine("名雖可得．利則難獲　凶帶吉"); break;
                case 39: Console.WriteLine("光明坦途．指日可待　吉"); break;
                case 40: Console.WriteLine("一盛一衰．浮沉不定　吉帶凶"); break;

                case 41: Console.WriteLine("天賦吉運．前途無限　吉"); break;
                case 42: Console.WriteLine("事業不專．十九不成　吉帶凶"); break;
                case 43: Console.WriteLine("忍耐自重．轉凶為吉　吉帶凶"); break;
                case 44: Console.WriteLine("事難遂願．貪功好進　凶"); break;
                case 45: Console.WriteLine("綠葉發枝．一舉成名　吉"); break;
                case 46: Console.WriteLine("坎坷不平．艱難重重　凶"); break;
                case 47: Console.WriteLine("有貴人助．可成大業　吉"); break;
                case 48: Console.WriteLine("名利俱全．繁榮富貴　吉"); break;
                case 49: Console.WriteLine("遇吉則吉．遇凶則凶　凶"); break;
                case 50: Console.WriteLine("吉凶互見．一成一敗　吉帶凶"); break;

                case 51: Console.WriteLine("一盛一衰．浮沉不常　吉帶凶"); break;
                case 52: Console.WriteLine("雨過天青．即獲成功　吉"); break;
                case 53: Console.WriteLine("盛衰參半．先吉後凶　吉帶凶"); break;
                case 54: Console.WriteLine("雖傾全力．難望成功　凶"); break;
                case 55: Console.WriteLine("外觀隆昌．內隱禍患　吉帶凶"); break;
                case 56: Console.WriteLine("事與願違．終難成功　凶"); break;
                case 57: Console.WriteLine("努力經營．時來運轉　吉"); break;
                case 58: Console.WriteLine("浮沉多端．始凶終吉　凶帶吉"); break;
                case 59: Console.WriteLine("遇事猶疑．難望成事　凶"); break;
                case 60: Console.WriteLine("心迷意亂．難定方針　凶"); break;

                case 61: Console.WriteLine("雲遮半月．百隱風波　吉帶凶"); break;
                case 62: Console.WriteLine("煩悶懊惱．事事難展　凶"); break;
                case 63: Console.WriteLine("萬物化育．繁榮之象　吉"); break;
                case 64: Console.WriteLine("十九不成．徒勞無功　凶"); break;
                case 65: Console.WriteLine("吉運自來．能享盛名　吉"); break;
                case 66: Console.WriteLine("內外不和．信用缺乏　凶"); break;
                case 67: Console.WriteLine("事事如意．富貴自來　吉"); break;
                case 68: Console.WriteLine("不失先機．可望成功　吉"); break;
                case 69: Console.WriteLine("動搖不安．常陷逆境　凶"); break;
                case 70: Console.WriteLine("慘澹經營．難免貧困　凶"); break;

                case 71: Console.WriteLine("吉凶參半．惟賴勇氣　吉帶凶"); break;
                case 72: Console.WriteLine("得而復失．難以安順　凶"); break;
                case 73: Console.WriteLine("安樂自來．自然吉祥　吉"); break;
                case 74: Console.WriteLine("如無智謀．難望成功　凶"); break;
                case 75: Console.WriteLine("吉中帶凶．進不如守　吉帶凶"); break;
                case 76: Console.WriteLine("此數大凶．破產之象　凶"); break;
                case 77: Console.WriteLine("先苦後甘．不致失敗　吉帶凶"); break;
                case 78: Console.WriteLine("有得有失．華而不實　吉帶凶"); break;
                case 79: Console.WriteLine("前途無光．希望不大　凶"); break;
                case 80: Console.WriteLine("得而復失．枉費心機　吉帶凶"); break;
                case 81: Console.WriteLine("最極之數．能得成功　吉"); break;
                default: break;
            }
        }
    }
}
