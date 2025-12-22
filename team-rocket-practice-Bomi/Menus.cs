using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_rocket_practice_Bomi
{
    public static class Menus
    {
        public static int KeyboardMenu(string[] items, string title = null)
        {
            int index = 0;

            while (true)
            {
                Console.Clear();

                if (!string.IsNullOrEmpty(title))
                {
                    Console.WriteLine(title);
                    Console.WriteLine(new string('-', title.Length));
                }

                for (int i = 0; i < items.Length; i++)
                {
                    if (i == index)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"> {items[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {items[i]}");
                    }
                }

                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                    index = (index - 1 + items.Length) % items.Length;
                else if (key == ConsoleKey.DownArrow)
                    index = (index + 1) % items.Length;
                else if (key == ConsoleKey.Enter)
                    return index;
            }
        }
    }
}
