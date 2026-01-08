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
        static void Main()
        {

            while (true)
            {
                string[] menu = {
                    "If/Else Practice",
                    "Loop Practice",
                    "Array Practice",
                    "String Practice",
                    "File/Random/Date Practice",
                    "Function Practice",
                    "離開" };
                int choice = Menus.KeyboardMenu(menu, "Main Menu");

                switch (choice)
                {
                    case 0:
                        IfElsePractice.Menu();
                        break;
                    case 1:
                        LoopPractice.Menu();
                        break;
                    case 2:
                        ArrayPractice.Menu();
                        break;
                    case 3:
                        StringPractice.Menu();
                        break;
                    case 4:
                        FileRandomDatePractice.Menu();
                        break;
                    case 5:
                        FunctionPractice.Menu();
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
