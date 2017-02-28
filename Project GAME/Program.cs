//The Coders Tribe
//Project_GAME

using System;
using System.Media;
using System.Windows.Input;
using System.IO;
using System.Diagnostics;

namespace THE_GAME
{
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