using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAME
{
    class say
    {
            public static void dialog(string postac, int kolor, string tekst)
        {
                //0 - narrator, 1 - gracz, 2 - postaci trzecie, 3 - special

                if (kolor == 0) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (kolor == 1) Console.ForegroundColor = ConsoleColor.Green;
                else if (kolor == 2) Console.ForegroundColor = ConsoleColor.DarkGreen;
                else Console.ForegroundColor = ConsoleColor.DarkYellow;

                if (postac != "n")
                {
                    Console.WriteLine("{0}", postac);
                    Console.ResetColor();
                }
                Console.WriteLine("{0}\n", tekst);
                Console.ResetColor();

                System.Threading.Thread.Sleep(500);
                Console.ReadKey(true);
            }

            public static int wybor(string[] x)
            {
                int b;
                do
                {
                    int i = 1;
                    Console.Clear();
                    Console.ResetColor();
                    Console.WriteLine("Co robisz?\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    foreach (string n in x)
                    {
                        Console.WriteLine("{0}. {1}", i, n);
                        i++;
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("Twór wybór: ");
                    bool a = int.TryParse(Console.ReadLine(), out b);
                    Console.WriteLine();
                }
                while ((b < 1) || (b > x.Length));
                return b;
            }
      }
}
