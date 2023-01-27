using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
    public class MenuArcade
    {
        public int indexMenu;

        public  void MenuJuegos()
        {
            ClearArrows();
            TransicionEntradaSpaceInvaders();
            PrintArrows();

            //ConsoleKey opc = ConsoleKey.Divide;

            //Console.Clear();
            //for (int i = 1; i > 2; i++)
            //{
            //    TransicionEntradaSpaceInvaders();
            //    TransicionSalidaSpaceInvaders();
            //    Thread.Sleep(1000);
            //}
        }

        public  void PrintArrows()
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

        public void ClearArrows()
        {
            // UP ARROW
            int x = 80;
            Console.SetCursorPosition(x, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 2);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 3);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 4);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 5);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 6);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 7);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 8);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 9);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 10);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 11);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 12);
            Console.Write(new string(' ', Console.WindowWidth));

            // DOWN ARROW
            Console.SetCursorPosition(x, 29);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 30);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 31);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 32);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 33);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 34);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 35);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 36);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 37);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 38);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 39);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 40);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, 41);
            Console.Write(new string(' ', Console.WindowWidth));
        }

        public  void TransicionEntradaSpaceInvaders()
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
                PrintArrows();

            opc = Console.ReadKey();

            switch (opc.Key)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.UpArrow:
                    ClearArrows();
                    TransicionSalidaSpaceInvaders();
                    TransicionEntradaSpaceInvaders();
                    break;
                case ConsoleKey.DownArrow:
                    ClearArrows();
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
