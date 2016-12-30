//The Coders Tribe
//Project_GAME

using System;
using System.Media;

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

            Console.ReadKey(true);
        }

        // TODO: Fabuła The_Mysterious_AREA - prowadzący - Gambler

        public static void The_Mysterious_Area()
        {
            var Music = new System.Media.SoundPlayer();
            Music.SoundLocation = @"data/audio/144950046.wav";
            Music.PlayLooping();

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
            say.dialog("n", 0, "W końcu dochodzicie do rozstaju dróg.");

            Console.ReadKey(true);

        }

        // TODO: Fabuła We_GODS - prowadzący - ImQ

        public static void We_Gods()
        {/*
            var Music = new System.Media.SoundPlayer();
            Music.SoundLocation = @"data/audio/in_the_morning.wav";
            Music.PlayLooping();

            System.Threading.Thread.Sleep(2000);

            say.dialog("n", 3, "Wszędzie wokół ciebie błyskają światła. W jednej dłoni trzymasz\npiwo, w drugiej papierosa. W uszach słyszysz szum od głośnej\nmuzyki.");
            say.dialog("n", 0, "Trzy metry od twojego stolika dostrzegasz dziewczynę. Uśmiecha\nsię do ciebie. Dopijasz resztkę piwa. Czujesz, że zaczyna działać.\nPo chwili jesteś przed nią.");

            int imie;
            do
                say.wybor2(imie, "Jak masz na imię?", "Odchodzisz.");
            while (imie != 1 && imie != 2);

            if (imie == 1)
            {
                say.dialog(player, 1, "Jak masz na imię?");
                say.dialog("n", 0, "Na jej twarzy pojawia się uśmiech.");
                say.dialog("???", 2, "Jestem Eva.");
                say.dialog("n", 0, "W jednej chwili wzdłuż całego twojego ciała przechodzi lodowaty dreszcz.\nW jej oczach dostrzegasz coś czego jeszcze nie nigdy nie widziałeś.\nPiękno. Pierwiastek boży.");

                int podryw;
                do
                {
                    say.wyborp();
                    Console.WriteLine("1. Całujesz ją.");
                    Console.WriteLine("2. Odchodzisz.");
                    //say.wybork(podryw);
                }
                while (podryw != 1 && podryw != 2);

                if (podryw == 1)
                {
                    say.dialog("n", 0, "Wasze usta spotykają się w namiętnym pocałunku. Czujesz się\ndoskonale. Jesteś panem tego miejsca. Samcem alfa.");
                }

            }

            Console.ReadKey(true);
            */
        }
    }

    public class minigame
    {
        //TODO: minigame HEIST - prowadzący - Maciek
        public static void Heist()
        {

        }

        //TODO: minigame RUNNING - prowadzący - ImQ
        public static void Running()
        {

        }

        //TODO: minigame TEXTS - prowadzący - Gambler
        public static void Texts()
        {

        }
    }

    public class say
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

            System.Threading.Thread.Sleep(500);
            Console.ReadKey(true);
        }

        //TODO: Funkcja będąca połączeniem wyborp i wybork

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

    public class menu
    {
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                            Console.WriteLine("Rafał 'Gambler' Kostun");
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
            while ((kampania != 1) && (kampania != 2) && (kampania != 3) && (kampania !=4));
            Console.Clear();

            if (kampania == 1) campaign.The_Heist();
            else if (kampania == 2) campaign.We_Gods();
            else if (kampania == 3) campaign.The_Mysterious_Area();
            else if (kampania == 4) menu_glowne();
            return kampania;
        }

        static void game_over()
        {
            Console.WriteLine("Przegrałeś.");
            Console.ReadKey(true);
            menu.menu_glowne();
        }
    }

    public class Program
    {
        public static string player = "Nieznajomy";

        static void Main(string[] args)
        {
            Console.Title = "Project_GAME";
            menu.intro();
            player = menu.name();
            menu.menu_glowne();
        }

    }
}