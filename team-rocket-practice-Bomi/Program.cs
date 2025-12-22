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
                string[] menu = { "If/Else Practice", "Loop Practice", "Array Practice", "離開" };
                int choice = Menus.KeyboardMenu(menu);

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
                        return;
                    default:
                        break;
                }
            }
            //Console.WriteLine("Choose which practice you want to check:");
            //IfElsePractice.Run();
            //LoopPractice.Run();
            //ArrayPractice.Run();
        }
    }
}
