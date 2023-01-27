﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
    //NOTAS
    //FLECHA HACIA ABAJO ++ Y FLECHA HACIA ARRIBA --

    public class MenuArcade
    {
        public int _juegos { get; set; }
        public int _opcMenu { get; set; }
        public bool _enter { get; set; }

        public MenuArcade()
        {
            _juegos = 2;
            _opcMenu = 0;
            _enter = false;
        }

        public void MenuJuegos()
        {
            _opcMenu = 0;

            ClearUpArrow();
            TransicionEntradaSpaceInvaders();
            PrintUpArrow();

            do
            {
                WaitForKey();

                switch (_opcMenu)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                }

            } while (!_enter);

            //TODO
            //Cuando pulsen enter, (mirar como hacer lista o algo con los juegos) usar _opcMenu para ejecutar el juego seleccionado
        }

        public void WaitForKey()
        {
            ConsoleKey key;
            key = Console.ReadKey().Key;

            if (key == ConsoleKey.UpArrow && _opcMenu > 0)
            {
                _opcMenu--;
            }
            else if (key == ConsoleKey.DownArrow && _opcMenu > _juegos - 1)
            {
                _opcMenu++;
            }
        }

        public void PrintUpArrow()
        {
            // UP ARROW
            int x = 80;
            Console.SetCursorPosition(x, 0);
            Console.WriteLine("     .\r\n");
            Console.SetCursorPosition(x, 1);
            Console.WriteLine("   .:;:.\r\n");
            Console.SetCursorPosition(x, 2);
            Console.WriteLine(" .:;;;;;:.\r\n");
            Console.SetCursorPosition(x, 3);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 4);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 5);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 6);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 7);
            Console.WriteLine("   ;:;;;\r\n");
            Console.SetCursorPosition(x, 8);
            Console.WriteLine("   : ;;;\r\n");
            Console.SetCursorPosition(x, 9);
            Console.WriteLine("     ;:;\r\n");
            Console.SetCursorPosition(x, 10);
            Console.WriteLine("   . :.;\r\n");
            Console.SetCursorPosition(x, 11);
            Console.WriteLine("     . :\r\n");
            Console.SetCursorPosition(x, 12);
            Console.WriteLine("   .   .\r\n");
        }

        public void PrintDownArrow()
        {
            // DOWN ARROW
            Console.SetCursorPosition(x, 29);
            Console.WriteLine("   . ;.\r\n");
            Console.SetCursorPosition(x, 30);
            Console.WriteLine("    .;\r\n");
            Console.SetCursorPosition(x, 31);
            Console.WriteLine("     ;;.\r\n");
            Console.SetCursorPosition(x, 32);
            Console.WriteLine("   ;.;;\r\n");
            Console.SetCursorPosition(x, 33);
            Console.WriteLine("   ;;;;.\r\n");
            Console.SetCursorPosition(x, 34);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 35);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 36);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 37);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 38);
            Console.WriteLine("   ;;;;;\r\n");
            Console.SetCursorPosition(x, 39);
            Console.WriteLine(" ..;;;;;..\r\n");
            Console.SetCursorPosition(x, 40);
            Console.WriteLine("  ':::::'\r\n");
            Console.SetCursorPosition(x, 41);
            Console.WriteLine("    ':`");
        }

        public void ClearUpArrow()
        {
            // UP ARROW
            int x = 80;
            for (int i = 0; i < 13; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }
        }

        public void ClearDownArrow()
        {
            // DOWN ARROW
            int x = 80;
            for (int i = 29; i < 42; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }
        }

        public void TransicionEntradaSpaceInvaders()
        {
            int x = 14;
            int limite = 25;
            ConsoleKeyInfo opc;

            for (int y = 1; y < limite; y++)
            {
                if (y > 7)
                {
                    Console.SetCursorPosition(x, y - 7);
                    Console.WriteLine(" ________  ________  ________  ________  _______           ___  ________   ___      ___ ________  ________  _______   ________  ________      \r\n");
                }
                if (y > 6)
                {
                    Console.SetCursorPosition(x, y - 6);
                    Console.WriteLine("|\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\|\\  ___ \\         |\\  \\|\\   ___  \\|\\  \\    /  /|\\   __  \\|\\   ___ \\|\\  ___ \\ |\\   __  \\|\\   ____\\     \r\n");
                }
                if (y > 5)
                {
                    Console.SetCursorPosition(x, y + -5);
                    Console.WriteLine("\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\ \\  \\\\ \\  \\ \\  \\  /  / | \\  \\|\\  \\ \\  \\_|\\ \\ \\   __/|\\ \\  \\|\\  \\ \\  \\___|_    \r\n");
                }
                if (y > 4)
                {
                    Console.SetCursorPosition(x, y - 4);
                    Console.WriteLine(" \\ \\_____  \\ \\   ____\\ \\   __  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\ \\  \\\\ \\  \\ \\  \\/  / / \\ \\   __  \\ \\  \\ \\\\ \\ \\  \\_|/_\\ \\   _  _\\ \\_____  \\   \r\n");
                }
                if (y > 3)
                {
                    Console.SetCursorPosition(x, y - 3);
                    Console.WriteLine("  \\|____|\\  \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\ \\  \\\\ \\  \\ \\    / /   \\ \\  \\ \\  \\ \\  \\_\\\\ \\ \\  \\_|\\ \\ \\  \\\\  \\\\|____|\\  \\  \r\n");
                }
                if (y > 2)
                {
                    Console.SetCursorPosition(x, y - 2);
                    Console.WriteLine("    ____\\_\\  \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\_______\\       \\ \\__\\ \\__\\\\ \\__\\ \\__/ /     \\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\__\\\\ _\\ ____\\_\\  \\ \r\n");
                }
                if (y > 1)
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("   |\\_________\\|__|     \\|__|\\|__|\\|_______|\\|_______|        \\|__|\\|__| \\|__|\\|__|/       \\|__|\\|__|\\|_______|\\|_______|\\|__|\\|__|\\_________\\\r\n");
                }
                if (y > 0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("   \\|_________|                                                                                                                   \\|_________|");
                }
                if (y > 8)
                {
                    Console.SetCursorPosition(x, y - 8);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
                Thread.Sleep(25);

                //Borra la letra introducida
                //Console.SetCursorPosition(x, y + 9);
                //Console.Write(new string(' ', Console.WindowWidth));
            }
                PrintUpArrow();

            opc = Console.ReadKey();

            switch (opc.Key)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.UpArrow:
                    ClearUpArrow();
                    TransicionSalidaSpaceInvaders();
                    TransicionEntradaSpaceInvaders();
                    break;
                case ConsoleKey.DownArrow:
                    ClearUpArrow();
                    TransicionSalidaSpaceInvaders();
                    TransicionEntradaSpaceInvaders();
                    break;
            }
        }

        public  void TransicionSalidaSpaceInvaders()
        {
            int x = 14;
            int limite = 42;

            for (int y = 16; y < limite; y++)
            {
                //TEXTO ARCADE
                if (y + 1 < limite)
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine(" ________  ________  ________  ________  _______           ___  ________   ___      ___ ________  ________  _______   ________  ________      \r\n");
                }
                if (y + 2 < limite)
                {
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("|\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\|\\  ___ \\         |\\  \\|\\   ___  \\|\\  \\    /  /|\\   __  \\|\\   ___ \\|\\  ___ \\ |\\   __  \\|\\   ____\\     \r\n");
                }
                if (y + 3 < limite)
                {
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\ \\  \\\\ \\  \\ \\  \\  /  / | \\  \\|\\  \\ \\  \\_|\\ \\ \\   __/|\\ \\  \\|\\  \\ \\  \\___|_    \r\n");
                }
                if (y + 4 < limite)
                {
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine(" \\ \\_____  \\ \\   ____\\ \\   __  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\ \\  \\\\ \\  \\ \\  \\/  / / \\ \\   __  \\ \\  \\ \\\\ \\ \\  \\_|/_\\ \\   _  _\\ \\_____  \\   \r\n");
                }
                if (y + 5 < limite)
                {
                    Console.SetCursorPosition(x, y + 5);
                    Console.WriteLine("  \\|____|\\  \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\ \\  \\\\ \\  \\ \\    / /   \\ \\  \\ \\  \\ \\  \\_\\\\ \\ \\  \\_|\\ \\ \\  \\\\  \\\\|____|\\  \\  \r\n");
                }
                if (y + 6 < limite)
                {
                    Console.SetCursorPosition(x, y + 6);
                    Console.WriteLine("    ____\\_\\  \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\_______\\       \\ \\__\\ \\__\\\\ \\__\\ \\__/ /     \\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\__\\\\ _\\ ____\\_\\  \\ \r\n");
                }
                if (y + 7 < limite)
                {
                    Console.SetCursorPosition(x, y + 7);
                    Console.WriteLine("   |\\_________\\|__|     \\|__|\\|__|\\|_______|\\|_______|        \\|__|\\|__| \\|__|\\|__|/       \\|__|\\|__|\\|_______|\\|_______|\\|__|\\|__|\\_________\\\r\n");
                }
                if (y + 8 < limite)
                {
                    Console.SetCursorPosition(x, y + 8);
                    Console.WriteLine("   \\|_________|                                                                                                                   \\|_________|");
                }
                Thread.Sleep(25);
                Console.SetCursorPosition(x, y + 1);
                Console.Write(new string(' ', Console.WindowWidth));
                //PrintArrows();
            }
        }
    }
}
