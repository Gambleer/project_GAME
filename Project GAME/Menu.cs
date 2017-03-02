using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAME
{
    public class menu
    {
        public static string poziom(int level)
        {
            string poziom = "";
            switch (level)
            {
                case 1: { poziom = "Łatwy"; break; }
                case 2: { poziom = "Normalny"; break; }
                case 3: { poziom = "Hardkorowy"; break; }
            }

            return poziom;
        }

        public static void intro()
        {
            char[] intro1 = new char[] { 'P', 'l', 'e', 'm', 'i', 'ę' };
            char[] intro2 = new char[] { 'P', 'r', 'o', 'g', 'r', 'a', 'm', 'i', 's', 't', 'ó', 'w' };
            char[] intro3 = new char[] { 'p', 'r', 'e', 'z', 'e', 'n', 't', 'u', 'j', 'e', '.', '.', '.' };

            System.Threading.Thread.Sleep(300);
            foreach (char a in intro1)
            {
                Console.Write(a);
                System.Threading.Thread.Sleep(70);
            }
            Console.Write(" "); System.Threading.Thread.Sleep(20);

            foreach (char a in intro2)
            {
                Console.Write(a);
                System.Threading.Thread.Sleep(70);
            }
            Console.Write(" "); System.Threading.Thread.Sleep(20);

            foreach (char a in intro3)
            {
                Console.Write(a);
                System.Threading.Thread.Sleep(70);
            }
            Console.Write(" "); System.Threading.Thread.Sleep(20);

            Console.Beep(1000, 200);
            Console.Beep(1500, 200);
            Console.Beep(2000, 200);
            Console.Beep(2500, 200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Project_GAME");
            System.Threading.Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
        }

        public static string name()
        {
            Console.Write("Podaj swoję imię: ");
            string name_string = Console.ReadLine();
            Console.Clear();

            if (name_string == "") name_string = "Nieznajomy";

            char[] intro4 = new char[] { 'H', 'e', 'l', 'l', 'o' };

            for (int i = 0; i < 5; i++)
            {
                Console.Write(intro4[i]);
                System.Threading.Thread.Sleep(70);
            }
            Console.Write(" "); System.Threading.Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}", name_string); Console.ResetColor(); Console.Write("!");

            System.Threading.Thread.Sleep(1000);
            var Melody = new System.Media.SoundPlayer();
            Melody.SoundLocation = @"data/audio/Forever.wav";
            Melody.PlayLooping();

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            return (name_string);
        }

        public static void menu_glowne()
        {
            int wybor_podmenu;
            do
            {
                Console.WriteLine("|MENU GLOWNE| Project_GAME v.1.0.0 | All rights reserved.");
                Console.Write("Gracz: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Program.player);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Kampania");
                Console.WriteLine("2. Rekordy punktowe");
                Console.WriteLine("3. Autorzy");
                Console.WriteLine("4. Wyjście");
                Console.WriteLine();
                Console.Write("Wybierz podmenu: ");
                bool b = int.TryParse(Console.ReadLine(), out wybor_podmenu);
                switch (wybor_podmenu)
                {
                    case 1:
                        {
                            Console.Clear();
                            wybor_kampanii();
                            break;
                        }
                    
                    case 2:
                        {
                            int kampania = 0;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Wybierz grę:\n");
                                Console.WriteLine("1. The Heist");
                                Console.WriteLine("2. We, Gods");
                                Console.WriteLine("3. The Mysterious Area");
                                Console.WriteLine();
                                Console.WriteLine("4. Cofnij");
                                Console.WriteLine();
                                Console.Write("Wybierz: ");
                                bool bo = int.TryParse(Console.ReadLine(), out kampania);
                                Console.Clear();
                            }
                            while ((kampania != 1) && (kampania != 2) && (kampania != 3) && (kampania != 4));
                            Console.Clear();

                            if (kampania == 1) wyswietl_rekord(1);
                            else if (kampania == 2) wyswietl_rekord(2);
                            else if (kampania == 3) wyswietl_rekord(3);
                            else if (kampania == 4) menu_glowne();
                            
                        } break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Autorzy:");
                            Console.WriteLine();
                            Console.WriteLine("Michał 'ImQ' Kropkowski");
                            Console.WriteLine("Rafał 'Gambleer' Kostun");
                            Console.WriteLine("Maciej Smyk");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.Write("Nacisnij dowolny klawisz, aby kontynuować.");
                            Console.ReadKey(true);
                            break;
                        }

                    case 4: Environment.Exit(0); break;
                    default: break;
                }
                Console.Clear();
            }
            while (wybor_podmenu != 1);
        }
        public static void wyswietl_rekord(int minigra)
        {
            Console.Clear();
            int level = 0;
            do
            {

                Console.WriteLine("Wybierz poziom trudność:\n");

                Console.Write("1. ");
                Console.Write("Easy\n");
                Console.Write("2. ");
                Console.Write("Normal\n");
                Console.Write("3. ");
                Console.WriteLine("Hardcore\n");

                Console.Write("Wybierz poziom: ");

                bool b = int.TryParse(Console.ReadLine(), out level);
                Console.Clear();

            } while (level != 1 && level != 2 && level != 3);
            do
            {
            Console.Clear();

            switch (level)
            {
                case 1: Console.WriteLine("Najlepszy wynik osiągnięty w tej grze to: {0} pkt. Dokonał tego {1}.\nGratulacje!", tablica_wynikow.odczytaj_wartosc(minigra, 1), tablica_wynikow.odczytaj_imie(minigra, 1)); break;
                case 2: Console.WriteLine("Najlepszy wynik osiągnięty w tej grze to: {0} pkt. Dokonał tego {1}.\nGratulacje!", tablica_wynikow.odczytaj_wartosc(minigra, 2), tablica_wynikow.odczytaj_imie(minigra, 2)); break;
                case 3: Console.WriteLine("Najlepszy wynik osiągnięty w tej grze to: {0} pkt. Dokonał tego {1}.\nGratulacje!", tablica_wynikow.odczytaj_wartosc(minigra, 3), tablica_wynikow.odczytaj_imie(minigra, 3)); break;
            }
            Console.WriteLine("\n\n<Wciśnij Escape, aby wrócić do menu>");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }

        public static int wybor_kampanii()
        {
            int kampania;
            do
            {
                Console.WriteLine("|WYBIERZ OPOWIEŚĆ|");
                Console.WriteLine();
                Console.WriteLine("1. The Heist");
                Console.WriteLine("2. We, Gods");
                Console.WriteLine("3. The Mysterious Area");
                Console.WriteLine();
                Console.WriteLine("4. Cofnij");
                Console.WriteLine();
                Console.Write("Wybierz: ");
                bool b = int.TryParse(Console.ReadLine(), out kampania);
                Console.Clear();
            }
            while ((kampania != 1) && (kampania != 2) && (kampania != 3) && (kampania != 4));
            Console.Clear();

            if (kampania == 1) Heist.The_Heist();
            else if (kampania == 2) wybor_rozdzialu();
            else if (kampania == 3) Mysterious.The_Mysterious_Area();
            else if (kampania == 4) menu_glowne();
            return kampania;
        }

        public static int wybor_rozdzialu()
        {
            int rozdzial;
            do
            {
                Console.WriteLine("|WYBIERZ ROZDZIAŁ|");
                Console.WriteLine();
                Console.WriteLine("Rozdział I: Chaos");
                Console.WriteLine("Rozdział II: My, Bogowie");
                Console.WriteLine("Rozdział III: Smierć.");
                Console.WriteLine();
                Console.WriteLine("4. Cofnij");
                Console.WriteLine();
                Console.Write("Wybierz: ");
                bool b = int.TryParse(Console.ReadLine(), out rozdzial);
                Console.Clear();
            }
            while ((rozdzial != 1) && (rozdzial != 2) && (rozdzial != 3) && (rozdzial != 4));
            if (rozdzial == 1) Gods.Chaos();
            else if (rozdzial == 2) Gods.My_Bogowie();
            else if (rozdzial == 3) Gods.Smierc();
            else if (rozdzial == 4) wybor_kampanii();

            return (rozdzial);
        }

        public static int poziom_trudnosci()
        {
            int level = 0;
            Console.Clear();

            do
            {
                Console.WriteLine("|POZIOM TRUDNOŚCI|");
                Console.WriteLine();

                Console.Write("1. ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Łatwy");
                Console.ResetColor();

                Console.WriteLine();

                Console.Write("2. Normalny");

                Console.WriteLine();

                Console.Write("3. ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Hardkorowy");
                Console.ResetColor();

                Console.WriteLine();
                Console.Write("Wybierz poziom: ");

                bool b = int.TryParse(Console.ReadLine(), out level);
                Console.Clear();

            }
            while (level != 1 && level != 2 && level != 3);

            Console.Clear();
            return level;
        }

        public static void game_over()
        {
            Console.WriteLine("Przegrałeś.");
            Console.ReadKey(true);
            Console.Clear();
            menu.menu_glowne();
        }
    }
}