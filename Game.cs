using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardMenu
{
    class Game
    {
        public void Start()
        {
            Console.Title = "Paint Drying - The Game!";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"
 ██▓███   ▄▄▄       ██▓ ███▄    █ ▄▄▄█████▓   ▓█████▄  ██▀███ ▓██   ██▓ ██▓ ███▄    █   ▄████ 
▓██░  ██▒▒████▄    ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒   ▒██▀ ██▌▓██ ▒ ██▒▒██  ██▒▓██▒ ██ ▀█   █  ██▒ ▀█▒
▓██░ ██▓▒▒██  ▀█▄  ▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░   ░██   █▌▓██ ░▄█ ▒ ▒██ ██░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░
▒██▄█▓▒ ▒░██▄▄▄▄██ ░██░▓██▒  ▐▌██▒░ ▓██▓ ░    ░▓█▄   ▌▒██▀▀█▄   ░ ▐██▓░░██░▓██▒  ▐▌██▒░▓█  ██▓
▒██▒ ░  ░ ▓█   ▓██▒░██░▒██░   ▓██░  ▒██▒ ░    ░▒████▓ ░██▓ ▒██▒ ░ ██▒▓░░██░▒██░   ▓██░░▒▓███▀▒
▒▓▒░ ░  ░ ▒▒   ▓▒█░░▓  ░ ▒░   ▒ ▒   ▒ ░░       ▒▒▓  ▒ ░ ▒▓ ░▒▓░  ██▒▒▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒ 
░▒ ░       ▒   ▒▒ ░ ▒ ░░ ░░   ░ ▒░    ░        ░ ▒  ▒   ░▒ ░ ▒░▓██ ░▒░  ▒ ░░ ░░   ░ ▒░  ░   ░ 
░░         ░   ▒    ▒ ░   ░   ░ ░   ░          ░ ░  ░   ░░   ░ ▒ ▒ ░░   ▒ ░   ░   ░ ░ ░ ░   ░ 
               ░  ░ ░           ░                ░       ░     ░ ░      ░           ░       ░ 
                                               ░               ░ ░                            


Welcome to the Paint Drying Simulator. What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("This game demo was created by Lazar Markovic");
            Console.WriteLine("It uses assets from the internet.");
            Console.WriteLine("This is just a demo... full game coming to console near you soon!");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey(true);
            RunMainMenu();
        }

        private void RunFirstChoice()
        {
            string prompt = "What color paint would you like to watch dry?";
            string[] options = { "Red", "Green", "Blue", "Yellow" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            Console.BackgroundColor = ConsoleColor.White;
            switch (selectedIndex)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nHere is some riveting red paint drying for you.");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nHere is some riveting green paint drying for you.");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nHere is some riveting blue paint drying for you.");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nHere is some riveting yellow paint drying for you.");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine("That's all for this game demo.");
            ExitGame();
        }
    }
}
