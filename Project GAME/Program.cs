//The Coders Tribe
//Project_GAME

using System;
using System.Media;
using System.Windows.Input;
using System.IO;
using System.Diagnostics;

namespace THE_GAME
{
    public class campaign
    {
        static string player = Program.player;
        // TODO: Fabuła The_Heist - prowadzący - Maciek

        public static void The_Heist()
        {
            var Music = new System.Media.SoundPlayer();
            Music.SoundLocation = @"data/audio/lidcreak.wav";
            Music.Play();

            System.Threading.Thread.Sleep(2000);

            say.dialog("n", 3, "< Miejsce: Opuszczony magazyn >\n< Data: Nieznana >\n< Godzina: 00:30 >");
            say.dialog("n", 0, "Pod osłoną nocy wchodzisz do środka budynku i rozglądasz się dookoła.");
            say.dialog("???", 2, "W końcu! Ileż można czekać.");
            say.dialog("n", 0, "Spoglądasz na uchylone drzwi na prawo od ciebie.");
            say.dialog("???", 2, "Masz kasę?");
            say.dialog("n", 0, "Rzucasz rulon pełen banknotów w stronę drzwi.");
            say.dialog(player, 1, "Powinienem dostać zniżkę Don. Wiesz ile się tu tłukłem?\nNie jestem jakimś studentem UG by SKM'kami zapie....");
            say.dialog("Don", 2, "Dobra, dobra. To co tu masz zwróci Ci za bilet. A teraz chodź i słuchaj.");
            say.dialog("n", 0, "Idziesz za Don'em do pokoju, gdzie widzisz na stole 3 pendrive'y.\nSą podpisane cyframi 1,2,3.");
            Console.Clear();

            say.dialog("Don", 2, "Tak jak chciałeś. Listy wszystkich mieszkańców, firm i innego\nbadziewia w tym mieście. Nie wiesz nawet ile to kompletowałem.\nA ty jeszcze zniżki chcesz.");
            say.dialog("n", 0, "Nie zwracając uwagi na narzekania Don'a wracasz do tematu.");
            say.dialog(player, 1, "A więc co dokładnie oznaczają te cyfry?");
            say.dialog("Don", 2, "1 to cele o najmniejszych zabezpieczeniach.\nOraz o najmniej pojemnych skarbonkach. Nie znajdziesz\nnic cennego, ale łup to łup.");
            say.dialog("Don", 2, "2 to cele o średnich zabezpieczeniach. Kilku korpo-gnojków.\nWiesz ludzi co mają tatusia na szczeblu lub wujka\nw prokuraturze i dostają ważne dane firmy jako część swoich\nprzywilejów. Przywilejów, które mogą zapewnić Ci trochę $$$\nna lewym koncie bankowym.");
            say.dialog("Don", 2, "3 to cele o największych zabezpieczeniach. Kojarzysz\nkilku miejscowych polityków co są zamieszani w kontakty\nz lokalnym Boss'em podziemia. Cóż nie zostaniesz raczej\nwpisany na liste jego ulubionych osób, jeżeli wybierzesz\ntę listę. Chyba, że lubisz pływać z rybkami w betnowych\nbucikach. Poza tym, że są to najcięższe sejfy to dodatkowo\nkręci się tam stała ochrona, więc nie będziesz mieć czasu\nna zwiedzanie.");
            Console.Clear();

            say.dialog("Don", 2, "A więc ... Co wybierasz?");

            //string[] z = new string[] { "Cele o najmniejszych zabezpieczeniach", "Cele o średnich zabezpieczeniach", "Cele o największych zabezpieczeniach" };
           // int zabezpieczenia = say.wybor(z);

           // Console.WriteLine("{0}", zabezpieczenia);

            minigame.Heist();

        }

        // TODO: Fabuła The_Mysterious_AREA - prowadzący - Gambleer

        public static void The_Mysterious_Area()
        {
            var Music = new System.Media.SoundPlayer();
            //Music.SoundLocation = @"data/audio/144950046.wav";
            Music.PlayLooping();
            System.Threading.Thread.Sleep(1000);
            int level = menu.poziom_trudnosci();
            System.Threading.Thread.Sleep(2000);
            

            say.dialog("n", 0, "<Wchodzisz do świątyni. Światło sklepienia pada Ci na twarz.\nCzerwone słońce zachodzi. Nadchodzi noc.>");

            say.dialog("Starzec", 2, "W końcu jesteś! Czekaliśmy na Ciebie, wybrańcze!");

            say.dialog("n", 0, "<Spoglądasz na starca.>");

            say.dialog(player, 1, "K..kim ty jesteś?");
            say.dialog("Starzec", 2, "Jestem nieistotnym pionkiem. Czekaliśmy na Ciebie, wybrańcze.");
            say.dialog("Starzec", 2, "To Ty jesteś tutaj najważniejszy.");
            say.dialog(player, 1, "Ja? Nawet nie pamiętam jak się tu znalazłem...");
            say.dialog("Starzec", 2, "Wybrańcze. Musisz nam pomóc, tylko Ty możesz to zrobić!");
            say.dialog("Starzec", 2, "Demony zaatakowały naszą wioskę. Mordują i plądrują.\nNie mamy czasu do stracenia.");

            say.dialog("n", 0, "<Mówi prawdę. Na zewnątrz słychać krzyki i zew wojny.>");
            
            say.dialog("Starzec", 2, "Chodź. Zaprowadzę Cię do krypty. Tam wypełnisz swe przeznaczenie.");
            
            Console.Clear();
            Music.Stop(); 
            
            say.dialog("n", 0, "Schodzicie w dół mrocznych katakumb. W nieznane.");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wpdałeś do labiryntu!");
            Console.WriteLine();
            Console.ReadKey();
            

            System.Threading.Thread.Sleep(500);
            
            Console.WriteLine("Wybrany poziom : {0}", menu.poziom(level));
            System.Threading.Thread.Sleep(300);
            Console.WriteLine();

            minigame.Maze(level);

            Console.ReadKey(true);

        }

        // TODO: Fabuła We_GODS - prowadzący - ImQ

        public static void We_Godsi()
        {
            Console.Write("ROZDZIAŁ I: CHAOS");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            var Music = new System.Media.SoundPlayer();
            Music.SoundLocation = @"data/audio/in_the_morning.wav";
            Music.PlayLooping();

            say.dialog("n", 3, "Wszędzie wokół ciebie błyskają światła. W jednej dłoni trzymasz\npiwo, w drugiej papierosa. W uszach słyszysz szum od głośnej\nmuzyki.");
            say.dialog("n", 0, "Trzy metry od twojego stolika dostrzegasz dziewczynę. Uśmiecha\nsię do ciebie. Dopijasz resztkę piwa. Czujesz, że zaczyna działać.\nPo chwili jesteś przed nią.");

            string[] z = new string[] { "Jak masz na imię?", "Odchodzisz." };
            int imie = say.wybor(z);

            if (imie == 1)
            {
                say.dialog(player, 1, "Jak masz na imię?");
                say.dialog("n", 0, "Na jej twarzy pojawia się uśmiech.");
                say.dialog("???", 2, "Jestem Eva.");
                say.dialog("n", 0, "W jednej chwili wzdłuż całego twojego ciała przechodzi lodowaty dreszcz.\nW jej oczach dostrzegasz coś czego jeszcze nie nigdy nie widziałeś.\nPiękno. Pierwiastek boży.");
                say.dialog("Eva", 2, "Haha, frajerze, nie jestem taka łatwa!");
                say.dialog("n", 0, "Uderza cię z pogardą z całej siły z liścia w twarz.");
                say.dialog("n", 0, "Popłakałeś się. Wszyscy się z ciebie śmieją. Uświadamiasz sobie, że\njesteś nikim. Powraca skryta fobia społeczna. Czujesz, że musisz uciekać...");
            }
            else
            {
                say.dialog("???", 2, "Hej, dupku, kutasiarzu pierdolony, nie ignoruj mnie dobra?!");
                say.dialog("n", 0, "Krzyczy, po czym łapie cię za ramię, przybliża się i zaczyna cię\nnamiętnie całować na francuza. Wszyscy wokół się na ciebie patrzą kiedy poziom \ntwojej erekcji dawno przekroczył granicę dobrego smaku.");
                say.dialog("n", 0, "Posikałeś się. Wszyscy się na ciebie patrzą. Śmieją się.\nKtoś z tyłu nazwał cię obszczymurkiem. Tak samo wyzywali cię w gimnazjum.\nWspomnienia powracają, dziewczyna cię od siebie odpycha,\nczujesz, że musisz uciekać...");
            }

            Music.Stop();
            minigame.Running(60, 10000);

            say.dialog("n", 0, "Wybiegasz na zewnątrz, podchodzisz do grupy jakichś ludzi.\nJest ich około pięciu, wszyscy dobrze się bawią. Nagle jeden z nich wyjmuje\nnaostrzony topór i wbija go innemu z nich w głowę. Krew tryska wszędzie.");
            say.dialog("n", 0, "Wszyscy uciekają w panice. Scena wygląda jak z horroru.\nPostanawiasz resuscytować mężczyznę.");

            minigame.Running(40, 7500);

            say.dialog("n", 0, "Cały jesteś we krwi. To wygląda jakbyś to ty był tym, który\nzabił. Boisz się. Łapiesz za topór i w ślad za innymi uciekasz.\nW tle słychać syreny...");

            minigame.Running(100, 13000);

            say.dialog("n", 0, "Umknąłeś policji. Szukasz odpowiedniego miejsca, aby wyrzucić\ntopór. Wrzucasz go na najwyższy dach budynku w okolicy.\nNagle przed tobą pojawia się grupka ludzi. Jedną z nich kojarzysz.");
            say.dialog("Eva", 1, "Dobrze się bawisz? Widziałam jakiego burdelu narobiłeś przed\nklubem. Haha, dobra robota. Szkoda życia na nudę!");

            say.dialog("n", 0, "Wszyscy wokół przytakneli. Dziwi cię to co słyszysz.\nZginął człowiek, a ich to w ogóle nie obchodzi?");

            z = new string[] { "Was to bawi?", "<śmiech>" };
            int nieznajomi = say.wybor(z);

            if(nieznajomi==1)
            {
                say.dialog(player, 1, "Bawi was to? Przecież w tym nie ma nic śmiesznego!");
                say.dialog("Eva", 1, "Błagam, nie dawaj nam tu jakichś moralniaków, chłopie.\nWszyscy Jesteśmy Bogami. Co ty na to, żebyśmy\nrazem posłali ten system w odmęty? Zniszczyli to\nco nas przez całe życie krzywdziło?");
            }
            else
            {
                say.dialog("n", 0, "Wybuchasz śmiechem.");
                say.dialog("Eva", 1, "O proszę. Widzę, że nie jesteś sztywniakiem jak wszyscy.\nRozumiesz, że Wszyscy Jesteśmy Bogami. Co ty na to, żebyśmy\nrazem posłali ten system w odmęty? Zniszczyli to\nco nas przez całe życie krzywdziło?");
                if (imie == 2) say.dialog("Eva", 1, "Mam chęć na powtórkę z całusa...");
            }

            say.dialog("n", 0, "Wyglądają niebezpiecznie. Spoglądają na ciebie z pełnią powagi.\nLepiej uważać na to co się mówi.");

            z = new string[] { "Nie ma mowy!", "Idę z wami." };
            int bogowie = say.wybor(z);

            if(bogowie == 1)
            {
                say.dialog(player, 1, "Dajcie mi spokój, dziwolągi! Ja stąd spadam!");
                say.dialog("Eva", 1, "Nie ma takiej opcji. Nie pozwolę na to.");
                say.dialog("n", 0, "Ewa zza pleców wyciąga AK-47, zanim zdążyłeś zareagować\nprzestrzeliła ci obydwa kolana. Leżysz na ziemi wykrwawiając się.");
                say.dialog("Eva", 1, "Mi się nie odmawia.");
                say.dialog("n", 0, "Strzela ci w głowę.");
                menu.game_over();
            }
            else
            {
                say.dialog(player, 1, "Kim wy jesteście? Dlaczego się tak dziwnie zachowujecie?");
                say.dialog("Eva", 1, "Jesteśmy ludźmi, którzy zrozumieli, że jesteśmy czymś więcej\njak pragnącą się rozmnażać tkanką. Śmierć jest niczym.\nGardzimy nią, bo wiemy, że po niej staniemy się\nczymś więcej.");
                say.dialog("Eva", 1, "Ten świat jest obrzydliwy. Bezcelowy. Nudny.\nNie ma sensu żyć według zasad, to do niczego nie prowadzi.\nNaszą odpowiedzialnością jest obudzenie w sobie Bogów.\nJesteśmy wolni. Robimy co chcemy. A potem umieramy.");
                say.dialog("n", 0, "Wiesz, że ma rację. Czułeś to przez całe życie.\nNiezliczona ilość prób samobójczych i depresja.\nTo rzeczywiście do nikąd nie prowadzi.");
                say.dialog("Eva", 1, "Łap gnata.");
                say.dialog("n", 0, "Rzuca AK-47 w twoją stronę. Łapiesz je i przyglądasz\nmu się z zaciekawieniem. Jeszcze nie miałeś czegoś\ntakiego w dłoniach.");
                say.dialog("Eva", 1, "Idziemy obrabować bank.");
            }
            Console.WriteLine("KONIEC ROZDZIAŁU I\n\n<Wciśnij Escape, aby wrócić do menu>");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            menu.wybor_kampanii();
        }

        public static void We_Godsii()
        {
            Console.Write("ROZDZIAŁ II: MY, BOGOWIE");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            say.dialog("n", 0, "Otacza was policja. Oczy łzawią od świateł.\nKtoś rzuca w stronę radiowozów parę granatów.\nEksplozja cię ogłusza, wyjmujesz broń i strzelasz.");
            say.dialog("Eva", 1, "Cholera! Ale jazda!");
            say.dialog("n", 0, "Nagle strzały ucichły. To chyba wszystko.\nPrzed wami stoi ogromny budynek jednego z\nnajbogatszych banków miasta. Ruszacie w jego kierunku.");

            minigame.Running(80, 10000);

            say.dialog("n", 0, "Wkraczacie przez ogromne patio do jeszcze większej\ngłównej sali banku.");
            say.dialog("Grey", 1, "WSZYSCY NA GLEBE, KURWA!");
            say.dialog("n", 0, "Krzyknął jeden z twoich towarzyszy i zaraz\npo tym wystrzelił serie w sufit.\nMasa tynku runęła na ziemię.");
            say.dialog("Eva", 1, "Tu jest ze sto osób! Co z nimi robimy?\nTrzymamy na zakładników, czy może urządzimy małą rzeź?");

           

            Console.WriteLine("KONIEC ROZDZIAŁU II\n\n<Wciśnij Escape, aby wrócić do menu>");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Clear();
            menu.wybor_kampanii();
        }

        public static void We_Godsiii()
        {
            Console.Write("ROZDZIAŁ III: ŚMIERC.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();



            Console.WriteLine("KONIEC ROZDZIAŁU III\n\n<Wciśnij Escape, aby wrócić do menu>");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Clear();
            menu.wybor_kampanii();
        }
    }


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

    public class minigame
    {
        //TODO: minigame HEIST - prowadzący - Maciek
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
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                Console.Clear();
                menu.menu_glowne();
            }
            else Console.WriteLine("- WYGRAŁEŚ\n\n<Wciśnij Escape, aby opuścić minigrę>");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Clear();
        }

        //TODO: minigame TEXTS - prowadzący - Gambleer
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static int przechwycony_wynik = 0;

        static double mnoznik(int level)
        {
            double value = 0;
            if (level == 1) value = 1.2;
            if (level == 2) value = 1.5;
            if (level == 3) value = 1.7;

            return value;
        }

        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

            
            return i-1;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            { Console.WriteLine("Żegnaj! :( Spróbuj łatwiejszego poziomu! ");
              Console.WriteLine();
              Console.WriteLine("<Wciśnij Escape, aby wrócić do menu>");
              while (Console.ReadKey(true).Key != ConsoleKey.Escape);
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

    public class menu
    {
        public static string poziom (int level)
            {

                string poziom = "";
                switch (level)
                {
                case 1: { poziom = "Easy"; break; }
                case 2: { poziom = "Normal"; break; }
                case 3: { poziom = "Hardcore"; break; }
                }

            return poziom;
        }

        public static void intro()
        {
            char[] intro1 = new char[] { 'P', 'l', 'e', 'm', 'i', 'ę' };
            char[] intro2 = new char[] { 'P', 'r', 'o', 'g', 'r', 'a', 'm', 'i', 's', 't', 'ó', 'w' };
            char[] intro3 = new char[] { 'p', 'r', 'e', 'z', 'e', 'n', 't', 'u', 'j', 'e', '.', '.', '.' };

            System.Threading.Thread.Sleep(300);
            foreach(char a in intro1)
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
                Console.WriteLine("|MENU GLOWNE|");
                Console.Write("Gracz: ", Program.player);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Program.player);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Kampania");
                Console.WriteLine("2. Autorzy");
                Console.WriteLine("3. Wyjście");
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
                            Console.Clear();
                            Console.WriteLine("Autorzy:");
                            Console.WriteLine();
                            Console.WriteLine("Michał 'ImQ' Kropkowski");
                            Console.WriteLine("Rafał 'Gambleer' Kostun");
                            Console.WriteLine("Maciej Smyk");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.Write("Nacisnij dowolny klawisz, aby kontynuować.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 3: Environment.Exit(0); break;
                    default: break;
                }
                Console.Clear();
            }
            while (wybor_podmenu != 1);
        }

        public static int poziom_trudnosci() 
        {
            int level = 0;
            Console.Clear();

            do
            {

            Console.WriteLine("Wybierz poziom trudności:");

            Console.WriteLine();

                Console.Write("1. ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Easy");
                Console.ResetColor();

                Console.WriteLine();

                Console.Write("2. ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Normal");
                Console.ResetColor();

                Console.WriteLine();

                Console.Write("3. ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Hardcore");
                Console.ResetColor();
                
                Console.WriteLine();

            Console.Write("Wybierz poziom: ");
                
            bool b = int.TryParse(Console.ReadLine(), out level);
            Console.Clear();
                
            }   while (level != 1 && level != 2 && level != 3);

            Console.Clear();
            return level;
        }


        public static int wybor_kampanii()
        {
            int kampania, rozdzial;
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
            while ((kampania != 1) && (kampania != 2) && (kampania != 3) && (kampania !=4));
            Console.Clear();

            if (kampania == 1) campaign.The_Heist();
            else if (kampania == 2)
            {
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
                if (rozdzial == 1) campaign.We_Godsi();
                else if (rozdzial == 2) campaign.We_Godsii();
                else if (rozdzial == 3) campaign.We_Godsiii();
                else if (rozdzial == 4) wybor_kampanii();
            }
            else if (kampania == 3) campaign.The_Mysterious_Area();
            else if (kampania == 4) menu_glowne();
            return kampania;
        }

        public static void game_over()
        {
            Console.WriteLine("Przegrałeś.");
            Console.ReadKey(true);
            Console.Clear();
            menu.menu_glowne();
        }
    }

    public class Program
    {
        public static string player = "Nieznajomy";

        static void Main(string[] args)
        {
            Console.Title = "Project_GAME";
            //menu.intro();
            //player = menu.name();
            menu.menu_glowne();
        }

    }
}