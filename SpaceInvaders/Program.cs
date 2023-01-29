using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(142, 40);
            Console.CursorVisible = false;
            MainMenu();
        }

        static void MainMenu()
        {
            ConsoleKeyInfo opc;

            do
            {
                Console.Clear();

                // TEXTO SPACE INVADERS
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("______________________________________________________________________________________________________________________________________________");
                Console.WriteLine(" ________  ________  ________  ________  _______           ___  ________   ___      ___ ________  ________  _______   ________  ________      \r\n|\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\|\\  ___ \\         |\\  \\|\\   ___  \\|\\  \\    /  /|\\   __  \\|\\   ___ \\|\\  ___ \\ |\\   __  \\|\\   ____\\     \r\n\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\ \\  \\\\ \\  \\ \\  \\  /  / | \\  \\|\\  \\ \\  \\_|\\ \\ \\   __/|\\ \\  \\|\\  \\ \\  \\___|_    \r\n \\ \\_____  \\ \\   ____\\ \\   __  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\ \\  \\\\ \\  \\ \\  \\/  / / \\ \\   __  \\ \\  \\ \\\\ \\ \\  \\_|/_\\ \\   _  _\\ \\_____  \\   \r\n  \\|____|\\  \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\ \\  \\\\ \\  \\ \\    / /   \\ \\  \\ \\  \\ \\  \\_\\\\ \\ \\  \\_|\\ \\ \\  \\\\  \\\\|____|\\  \\  \r\n    ____\\_\\  \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\_______\\       \\ \\__\\ \\__\\\\ \\__\\ \\__/ /     \\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\__\\\\ _\\ ____\\_\\  \\ \r\n   |\\_________\\|__|     \\|__|\\|__|\\|_______|\\|_______|        \\|__|\\|__| \\|__|\\|__|/       \\|__|\\|__|\\|_______|\\|_______|\\|__|\\|__|\\_________\\\r\n   \\|_________|                                                                                                                   \\|_________|\r\n                                                                                                                                              \r\n");
                Console.SetCursorPosition(0, 9);
                Console.WriteLine("______________________________________________________________________________________________________________________________________________\n");

                // TEXTO PLAY
                Console.SetCursorPosition(58, 13);
                Console.WriteLine("       __        _       \r\n");
                Console.SetCursorPosition(58, 14);
                Console.WriteLine("-/    /__/  /   /_| /__/ \r\n");
                Console.SetCursorPosition(58, 15);
                Console.WriteLine("/ .  /     /__ /  |  /  ");

                // TEXTO SCOREBOARD
                Console.SetCursorPosition(42, 17);
                Console.WriteLine(" _      __   _    __    __    ___  __    ___   _    __    __  \r\n");
                Console.SetCursorPosition(42, 18);
                Console.WriteLine(" _)    (    / )  /  /  /__)  /_   /__)  /  /  /_|  /__)  /  ) \r\n");
                Console.SetCursorPosition(42, 19);
                Console.WriteLine("/__.  __)  (__  /__/  / \\   /__  /__)  /__/  /  | / \\   /__/  ");

                // TEXTO EXIT
                Console.SetCursorPosition(56, 21);
                Console.WriteLine(" _      ___        ____ \r\n");
                Console.SetCursorPosition(56, 22);
                Console.WriteLine(" _)    /_   \\_)  /  /   \r\n");
                Console.SetCursorPosition(56, 23);
                Console.WriteLine("__).  /__  ( \\  /  /  ");

                opc = Console.ReadKey();

            } while (opc.Key < ConsoleKey.D1 || opc.Key > ConsoleKey.D3);

            switch (opc.Key)
            {
                case ConsoleKey.D1:
                    DifficultyMenu();
                    break;
                case ConsoleKey.D2:
                    scoreBoard();
                    break;
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }
        }

        static void DifficultyMenu()
        {
            ConsoleKeyInfo opc;

            do
            {
                Console.Clear();

                // TEXTO SPACE INVADERS
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("______________________________________________________________________________________________________________________________________________");
                Console.WriteLine(" ________  ________  ________  ________  _______           ___  ________   ___      ___ ________  ________  _______   ________  ________      \r\n|\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\|\\  ___ \\         |\\  \\|\\   ___  \\|\\  \\    /  /|\\   __  \\|\\   ___ \\|\\  ___ \\ |\\   __  \\|\\   ____\\     \r\n\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\ \\  \\\\ \\  \\ \\  \\  /  / | \\  \\|\\  \\ \\  \\_|\\ \\ \\   __/|\\ \\  \\|\\  \\ \\  \\___|_    \r\n \\ \\_____  \\ \\   ____\\ \\   __  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\ \\  \\\\ \\  \\ \\  \\/  / / \\ \\   __  \\ \\  \\ \\\\ \\ \\  \\_|/_\\ \\   _  _\\ \\_____  \\   \r\n  \\|____|\\  \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\ \\  \\\\ \\  \\ \\    / /   \\ \\  \\ \\  \\ \\  \\_\\\\ \\ \\  \\_|\\ \\ \\  \\\\  \\\\|____|\\  \\  \r\n    ____\\_\\  \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\_______\\       \\ \\__\\ \\__\\\\ \\__\\ \\__/ /     \\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\__\\\\ _\\ ____\\_\\  \\ \r\n   |\\_________\\|__|     \\|__|\\|__|\\|_______|\\|_______|        \\|__|\\|__| \\|__|\\|__|/       \\|__|\\|__|\\|_______|\\|_______|\\|__|\\|__|\\_________\\\r\n   \\|_________|                                                                                                                   \\|_________|\r\n                                                                                                                                              \r\n");
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("______________________________________________________________________________________________________________________________________________\n");

                // TEXTO PRINCIPIANTE
                Console.SetCursorPosition(42, 13);
                Console.WriteLine("       __    __             _       __       _        ____   ___ \r\n");
                Console.SetCursorPosition(42, 14);
                Console.WriteLine("-/    /__)  /__)  /  /| /  / )  /  /__)  /  /_|  /| /  /    /_  \r\n");
                Console.SetCursorPosition(42, 15);
                Console.WriteLine("/ .  /     / \\   /  / |/  (__  /  /     /  /  | / |/  /    /__  ");

                // TEXTO INTERMEDIO
                Console.SetCursorPosition(45, 17);
                Console.WriteLine(" _             ____   ___  __          ___  __       ___  \r\n");
                Console.SetCursorPosition(45, 18);
                Console.WriteLine(" _)    /  /| /  /    /_   /__)  /|/|  /_   /  )  /  /  / \r\n");
                Console.SetCursorPosition(45, 19);
                Console.WriteLine("/__.  /  / |/  /    /__  / \\   /   | /__  /__/  /  /__/  ");

                // TEXTO AVANZADO
                Console.SetCursorPosition(47, 21);
                Console.WriteLine(" _      _         _         __   _    __    ___  \r\n");
                Console.SetCursorPosition(47, 22);
                Console.WriteLine(" _)    /_| |  /  /_|  /| /  _/  /_|  /  )  /  / \r\n");
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("__).  /  | |_/  /  | / |/  /__ /  | /__/  /__/ ");

                // TEXTO EXPERTO
                Console.SetCursorPosition(49, 25);
                Console.WriteLine("        ___       __    ___  __  ____   ___  \r\n");
                Console.SetCursorPosition(49, 26);
                Console.WriteLine("(_/    /_   \\_)  /__)  /_   /__)  /    /  /\r\n");
                Console.SetCursorPosition(49, 27);
                Console.WriteLine(" / .  /__  ( \\  /     /__  / \\   /    /__/");

                // TEXTO VOLVER
                Console.SetCursorPosition(51, 30);
                Console.WriteLine(" __          ___            ___  ___  \r\n");
                Console.SetCursorPosition(51, 31);
                Console.WriteLine("/_    |  /  /  /  /  |  /  /_   /__/ \r\n");
                Console.SetCursorPosition(51, 32);
                Console.WriteLine("__).  |_/  /__/  /__ |_/  /__  / \\  ");

                opc = Console.ReadKey();

            } while (opc.Key < ConsoleKey.D1 || opc.Key > ConsoleKey.D5);

            switch (opc.Key)
            {
                case ConsoleKey.D1:
                    NewGame();
                    break;
                case ConsoleKey.D2:
                    NewGame();
                    break;
                case ConsoleKey.D3:
                    NewGame();
                    break;
                case ConsoleKey.D4:
                    NewGame();
                    break;
                case ConsoleKey.D5:
                    MainMenu();
                    break;
            }
        }

        static void NewGame()
        {
            Game game = new Game();
            Player player = new Player();
            game.Load();
            game.CountDown();
            game.Start();
        }

        static void scoreBoard()
        {

        }
    }
}