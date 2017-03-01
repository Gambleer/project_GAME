using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace THE_GAME
{

    public class tablica_wynikow
    {

        /*tablica_wynikow.wpisz_wynik(3, level, Program.player, przechwycony_wynik);
        Tak wygląda funkcja której się używa do wpisania wyniku do tablicy rekordów,
        reszta już działa jak należy, 3 oznacza numer minigry w mim przypadku 3, level to tez 1 2 albo 3 od najlatwiejszego czyli 1 ,,
        przechwycony winik to akurat moja zmienna z wynikiem Wy tu wstawicie jakaś zmienna odpowiedzialną za wynik
        */

        public static int odczytaj_wartosc(int minigra, int level)
        {
            int x = 0;


            switch (minigra)
            {
                case 1:
                    {

                        if (level == 1)
                        {

                            string nazwaPliku = @"save\heist-easy.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 2)
                        {

                            string nazwaPliku = @"save\heist-normal.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 3)
                        {

                            string nazwaPliku = @"save\heist-hardcore.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                    }
                    break;
                    
                case 2:
                    {

                        if (level == 1)
                        {

                            string nazwaPliku = @"save\running-easy.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 2)
                        {

                            string nazwaPliku = @"save\running-normal.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 3)
                        {

                            string nazwaPliku = @"save\running-hardcore.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                    }
                    break;

                case 3:
                    {

                        if (level == 1)
                        { 

                        string nazwaPliku = @"save\maze-easy.txt";
                        FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                        System.IO.StreamReader odczyt = new StreamReader(plik);

                        x = Convert.ToInt32(odczyt.ReadLine());

                        odczyt.Close();
                        plik.Close();

                        }

                        if (level == 2)
                        {

                            string nazwaPliku = @"save\maze-normal.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 3)
                        {

                            string nazwaPliku = @"save\maze-hardcore.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            x = Convert.ToInt32(odczyt.ReadLine());

                            odczyt.Close();
                            plik.Close();

                        }

                    } break;

            }
            
            return x;
        }

        public static void wpisz_wynik(int minigra, int level, string player, int wynik)
        {

            switch (minigra)

            {

                case 1:

                    {
                        if (level == 1)

                        {
                            string nazwaPliku = @"save\heist-easy.txt";
                            string nazwaPliku2 = @"save\heist-easy-name.txt";

                            int temp = odczytaj_wartosc(1, 1);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }

                        if (level == 2)

                        {
                            string nazwaPliku = @"save\heist-normal.txt";
                            string nazwaPliku2 = @"save\heist-normal-name.txt";

                            int temp = odczytaj_wartosc(1, 2);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }

                        if (level == 3)

                        {
                            string nazwaPliku = @"save\heist-hardcore.txt";
                            string nazwaPliku2 = @"save\heist-hardcore-name.txt";

                            int temp = odczytaj_wartosc(1, 3);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }
                    }
                    break;


                case 2:

                    {
                        if (level == 1)

                        {
                            string nazwaPliku = @"save\running-easy.txt";
                            string nazwaPliku2 = @"save\running-easy-name.txt";

                            int temp = odczytaj_wartosc(2, 1);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }

                        if (level == 2)

                        {
                            string nazwaPliku = @"save\running-normal.txt";
                            string nazwaPliku2 = @"save\running-normal-name.txt";

                            int temp = odczytaj_wartosc(2, 2);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }

                        if (level == 3)

                        {
                            string nazwaPliku = @"save\running-hardcore.txt";
                            string nazwaPliku2 = @"save\running-hardcore-name.txt";

                            int temp = odczytaj_wartosc(2, 3);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }
                    }
                    break;
                case 3:

                    {
                        if (level == 1)

                        {
                            string nazwaPliku = @"save\maze-easy.txt";
                            string nazwaPliku2 = @"save\maze-easy-name.txt";

                            int temp = odczytaj_wartosc(3,1);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }

                        if (level == 2)

                        {
                            string nazwaPliku = @"save\maze-normal.txt";
                            string nazwaPliku2 = @"save\maze-normal-name.txt";

                            int temp = odczytaj_wartosc(3,2);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }

                        if (level == 3)

                        {
                            string nazwaPliku = @"save\maze-hardcore.txt";
                            string nazwaPliku2 = @"save\maze-hardcore-name.txt";

                            int temp = odczytaj_wartosc(3,3);

                            if (temp < wynik)
                            {
                                FileStream plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis = new StreamWriter(plik);

                                zapis.Write(wynik);
                                zapis.Close();
                                plik.Close();

                                FileStream plik2 = new FileStream(nazwaPliku2, FileMode.Create, FileAccess.Write, FileShare.None);
                                System.IO.StreamWriter zapis2 = new StreamWriter(plik2);

                                zapis2.Write(player);
                                zapis2.Close();
                                plik2.Close();
                            }
                        }
                    } break;
            }
        }

        public static string odczytaj_imie(int minigra, int level)
        {
            string player = "";


            switch (minigra)
            {

                case 1:
                    {

                        if (level == 1)
                        {

                            string nazwaPliku = @"save\heist-easy-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 2)
                        {

                            string nazwaPliku = @"save\heist-normal-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 3)
                        {

                            string nazwaPliku = @"save\heist-hardcore-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                    }
                    break;

                case 2:
                    {

                        if (level == 1)
                        {

                            string nazwaPliku = @"save\running-easy-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 2)
                        {

                            string nazwaPliku = @"save\running-normal-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 3)
                        {

                            string nazwaPliku = @"save\running-hardcore-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                    }
                    break;
                    
                case 3:
                    {

                        if (level == 1)
                        {

                            string nazwaPliku = @"save\maze-easy-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 2)
                        {

                            string nazwaPliku = @"save\maze-normal-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                        if (level == 3)
                        {

                            string nazwaPliku = @"save\maze-hardcore-name.txt";
                            FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                            System.IO.StreamReader odczyt = new StreamReader(plik);

                            player = odczyt.ReadLine();

                            odczyt.Close();
                            plik.Close();

                        }

                    }
                    break;

            }

            return player;
        }
    }
}