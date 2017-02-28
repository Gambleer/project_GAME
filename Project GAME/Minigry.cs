using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace THE_GAME
{
    public class minigame
    {
        public static void Heist()
        {
            int a, b, c, d, e, w = 0, s = 3;
            Random r = new Random();
            int[] tab = new int[5];

            Console.WriteLine("Celem gry jest prawidłowe zapamiętanie i wpisanie w odpowiedniej kolejności");
            Console.WriteLine("pojawiających się cyfr. Po wpisaniu każdej liczby naciśnij Enter by wpisać ");
            Console.WriteLine("kolejną. Baw się dobrze polub nas na Facebooku, zasubuj na YouTube,");
            Console.WriteLine("śledź nas na Twitterze oraz hojnie wpłacaj kasę na nasz profil na Kickstarterze :D");
            Console.WriteLine("");
            Console.WriteLine("<Wciśnij Enter, aby rozpocząć grę>");
            Console.ReadLine();
            Console.Clear();

            for (int j = 0; j < 1000; j++)
            {

                for (int i = 0; i < tab.Length; i++)
                    tab[i] = r.Next(0, 10);

                for (int i = 0; i < tab.Length; i++)
                {
                    Console.Write("{0}", tab[i]);
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }

                Console.WriteLine("Podaj kod do sejfu:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
                e = Convert.ToInt32(Console.ReadLine());

                if ((a == tab[0]) && (b == tab[1]) && (c == tab[2]) && (d == tab[3]) && (e == tab[4]))
                {
                    Console.WriteLine("Łup jest twój.");
                    w++;
                    Console.WriteLine("<Wciśnij dowolny klawisz>");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Włączył się alarm!");
                    s--;
                    if (s == 0)
                    {
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Koniec gry");
                        Console.WriteLine("Twój wynik to {0}", w);
                        break;
                    }
                    else if (s == 1)
                    {
                        Console.WriteLine("Została Ci tylko {0} szansa", s);
                        Console.WriteLine("<Wciśnij dowolny klawisz>");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Zostały Ci tylko {0} szanse", s);
                        Console.WriteLine("<Wciśnij dowolny klawisz>");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }
            }

            Console.ReadLine();
            Console.Clear();
            menu.menu_glowne();
        }

        static int losuj_strzalke()
        {

            Random r = new Random();
            int x = r.Next(1, 5);
            return x;
        }

        //TODO: minigame RUNNING - prowadzący - ImQ
        public static void Running(int Potrzebne_Wcisniecia, int Czas)
        {
            Console.Clear();
            Console.WriteLine("PRZYGOTUJ SIĘ...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Naciskaj wskazany klawisz najszybciej jak potrafisz.");
            System.Threading.Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("SZYBCIEJ!");
            Console.ResetColor();

            var Key1 = ConsoleKey.UpArrow;
            var Key2 = ConsoleKey.DownArrow;
            var Key3 = ConsoleKey.LeftArrow;
            var Key4 = ConsoleKey.RightArrow;

            int Liczba_Wcisniec = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int kierunek = losuj_strzalke();
            if (kierunek == 1) Console.WriteLine("GÓRA");
            else if (kierunek == 2) Console.WriteLine("DÓŁ");
            else if (kierunek == 3) Console.WriteLine("LEWO");
            else if (kierunek == 4) Console.WriteLine("PRAWO");

            while (sw.ElapsedMilliseconds < Czas)
            {
                switch (kierunek)
                {
                    case 1:
                        {
                            if (Key1 == Console.ReadKey(true).Key)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("DOBRZE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec++;
                                System.Threading.Thread.Sleep(1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("ŹLE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec--;
                                System.Threading.Thread.Sleep(1);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (Key2 == Console.ReadKey(true).Key)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("DOBRZE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec++;
                                System.Threading.Thread.Sleep(1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("ŹLE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec--;
                                System.Threading.Thread.Sleep(1);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Key3 == Console.ReadKey(true).Key)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("DOBRZE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec++;
                                System.Threading.Thread.Sleep(1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("ŹLE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec--;
                                System.Threading.Thread.Sleep(1);
                            }
                            break;
                        }
                    case 4:
                        {
                            if (Key4 == Console.ReadKey(true).Key)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("DOBRZE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec++;
                                System.Threading.Thread.Sleep(1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("ŹLE! ");
                                Console.ResetColor();
                                Liczba_Wcisniec--;
                                System.Threading.Thread.Sleep(1);
                            }
                            break;
                        }
                }
            }
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP\n");
            Console.ResetColor();
            Console.WriteLine("Liczba wciśnięć = {0}", Liczba_Wcisniec);
            Console.WriteLine("Potrzebna liczba wciśnięć = {0}", Potrzebne_Wcisniecia);

            if (Liczba_Wcisniec < Potrzebne_Wcisniecia)
            {
                Console.WriteLine("- PRZEGRAŁEŚ\n\n<Wciśnij Escape, aby opuścić minigrę>");
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                Console.Clear();
                menu.menu_glowne();
            }
            else Console.WriteLine("- WYGRAŁEŚ\n\n<Wciśnij Escape, aby opuścić minigrę>");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
            Console.Clear();
        }

        static int przechwycony_wynik = 0;

        static double mnoznik(int level)
        {
            double value = 0;
            if (level == 1) value = 1.2;
            if (level == 2) value = 1.5;
            if (level == 3) value = 2;

            return value;
        }

        static int testuj_strzalki()
        {

            Stopwatch zegar = new Stopwatch();

            zegar.Start();

            int test2 = 0, temp1 = 1, temp2 = 1, temp3 = 1, temp4 = 1;

            int i = 0;

            do

            {

                int number = losuj_strzalke();

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Kliknij strzałke w górę");

                        var Key2 = Console.ReadKey(true).Key == ConsoleKey.UpArrow;
                        test2 = Convert.ToInt16(Key2);
                        temp1 = test2;

                        break;


                    case 2:
                        Console.WriteLine("Kliknij strzałke w dół");

                        var Key4 = Console.ReadKey(true).Key == ConsoleKey.DownArrow;
                        test2 = Convert.ToInt16(Key4);
                        temp2 = test2;

                        break;


                    case 3:
                        Console.WriteLine("Kliknij strzałke w prawo");

                        var Key6 = Console.ReadKey(true).Key == ConsoleKey.RightArrow;
                        test2 = Convert.ToInt16(Key6);
                        temp3 = test2;

                        break;


                    case 4:
                        Console.WriteLine("Kliknij strzałke w lewo");

                        var Key8 = Console.ReadKey(true).Key == ConsoleKey.LeftArrow;
                        test2 = Convert.ToInt16(Key8);
                        temp4 = test2;

                        break;
                }

                i++;

            } while (temp1 == 1 && temp2 == 1 && temp3 == 1 && temp4 == 1 && zegar.ElapsedMilliseconds <= 30000);

            return i - 1;
        }

        static int start_gry(int level)

        {
            int zwracana = 0;


            for (int i = 3; i > 0; i--)
            {

                Console.WriteLine();
                Console.ReadKey();


                int wynik = testuj_strzalki();
                if (wynik >= 30 * mnoznik(level)) przechwycony_wynik = wynik;

                Console.WriteLine();


                Console.WriteLine("Twój wynik to: {0}", wynik); // Pobierz wartość czy błędnie kliknięto czy jest timeout, warotś za duża o 1

                if (wynik >= 30 * mnoznik(level)) { Console.WriteLine("Udało Ci się przejść ten poziom!"); i = 0; zwracana = 1; }
                else { Console.WriteLine("Przegrałeś! Aby przejść ten poziom potrzebujesz minimum {0}!", 30 * mnoznik(level)); zwracana = 0; }

                Console.WriteLine();

                if (i > 2)
                {
                    Console.WriteLine("Pozostały Ci {0} życia", i - 1);
                    Console.WriteLine();
                    Console.WriteLine("Spóbuj jeszcze raz!");
                }
                if (i == 2)

                {
                    Console.WriteLine("Pozostało Ci {0} życie", i - 1);
                    Console.WriteLine();
                    Console.WriteLine("Spóbuj jeszcze raz!");
                }
            }
            return zwracana;
        }

        public static void Maze(int level)
        {
            Console.WriteLine("Na każdym rozwidleniu dróg musisz kliknąć odpowiednią strzałkę, jeśli sie pomylisz - prezgrasz!");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Masz 30s na pokonanie labiryntu, a minimalny wynik jaki musisz osiągnąć to: {0}", 30 * mnoznik(level));
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Masz 3 życia");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Kliknij klawisz aby zacząć!");


            double kontynuacja = start_gry(level);

            if (kontynuacja != 1)
            {
                Console.WriteLine("Żegnaj! :( Spróbuj łatwiejszego poziomu! ");
                Console.WriteLine();
                Console.WriteLine("<Wciśnij Escape, aby wrócić do menu>");
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                Console.Clear();
                Console.ResetColor();
                menu.menu_glowne();
            }
            else
            Console.WriteLine("Gratulacje! Grasz dalej! :) ");
            Console.WriteLine();
            Console.WriteLine("Twoje osiągnięcie: {0} pkt na poziomie trudności: {1} , zostanie zapisaane na Tablicy Wyników!", przechwycony_wynik, menu.poziom(level));

            // przechwycony_wynik
            // level
            // i imię 

            tablica_wynikow.wpisz_wynik(1, 11); // do ogarnięcia

            Console.ReadKey(true);
        }
    }
}
