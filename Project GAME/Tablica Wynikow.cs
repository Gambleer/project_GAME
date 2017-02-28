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

        public static int odczytaj_wartosc(int numer_save)
        {
            string nazwaPliku = @"save\minigame1.txt";
            FileStream plik1 = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik1);

            int s = Convert.ToInt32(odczyt.ReadLine());

            odczyt.Close();
            plik1.Close();

            return s;
        }

        public static void wpisz_wynik(int numer_pliku, int wartosc)
        {

            if (numer_pliku == 1)

            {
                string nazwaPliku = @"save\minigame1.txt";

                int temp = odczytaj_wartosc(1);

                if (temp < wartosc)
                {
                    FileStream plik1 = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                    System.IO.StreamWriter zapis = new StreamWriter(plik1);

                    zapis.Write(wartosc);
                    zapis.Close();
                    plik1.Close();
                }
            }

            if (numer_pliku == 2)

            {
                string nazwaPliku = @"save\minigame1.txt";

                int temp = odczytaj_wartosc(2);

                if (temp < wartosc)
                {
                    FileStream plik2 = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                    System.IO.StreamWriter zapis = new StreamWriter(plik2);

                    zapis.Write(wartosc);
                    zapis.Close();
                    plik2.Close();
                }
            }

            if (numer_pliku == 3)

            {
                string nazwaPliku = @"save\minigame1.txt";

                int temp = odczytaj_wartosc(3);

                if (temp < wartosc)
                {
                    FileStream plik3 = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);
                    System.IO.StreamWriter zapis = new StreamWriter(plik3);

                    zapis.Write(wartosc);
                    zapis.Close();
                    plik3.Close();
                }
            }

        }
    }
}