using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAME
{
    class Heist
    {
        static string player = Program.player;

        public static void The_Heist()
        {
            var Music = new System.Media.SoundPlayer();
            Music.SoundLocation = @"data/audio/Heist.wav";
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
    }

    class Mysterious
    {
        static string player = Program.player;

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
    }

    class Gods
    {
        static string player = Program.player;

        public static void Chaos()
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

                if (nieznajomi == 1)
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

                if (bogowie == 1)
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
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                menu.wybor_rozdzialu();
            }

        public static void My_Bogowie()
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
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                Console.Clear();
                menu.wybor_kampanii();
                }

        public static void Smierc()
                {
                Console.Write("ROZDZIAŁ III: ŚMIERC.");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();



                Console.WriteLine("KONIEC ROZDZIAŁU III\n\n<Wciśnij Escape, aby wrócić do menu>");
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                Console.Clear();
                menu.wybor_kampanii();
                }
        }
}
