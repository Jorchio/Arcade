using System.Runtime.CompilerServices;

namespace Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(170, 43);

            bool opc;
            MenuArcade menu = new MenuArcade();

            PrintTitleScreen();
            opc = ArcadeWaitForKey();

            if (opc)
            {
                TransicionSalidaArcade();
                menu.MenuJuegos();
            }
        }

        static void PrintTitleScreen()
        {
            int x = 10;
            int y = 1;
            //Texto Arcade
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("          _____                    _____                    _____                    _____                    _____                    _____          \r\n");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("         /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\         \r\n");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("        /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\        \r\n");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("       /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\       \r\n");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("      /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\      \r\n");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("     /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\     \r\n");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("    /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/  \\:::\\    \\        /:::/__\\:::\\    \\        /:::/  \\:::\\    \\        /:::/__\\:::\\    \\    \r\n");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("   /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\      /:::/    \\:::\\    \\      /::::\\   \\:::\\    \\      /:::/    \\:::\\    \\      /::::\\   \\:::\\    \\   \r\n");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("  /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\    /:::/    / \\:::\\    \\    /::::::\\   \\:::\\    \\    /:::/    / \\:::\\    \\    /::::::\\   \\:::\\    \\  \r\n");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine(" /:::/\\:::\\   \\:::\\    \\  /:::/\\:::\\   \\:::\\____\\  /:::/    /   \\:::\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/    /   \\:::\\ ___\\  /:::/\\:::\\   \\:::\\    \\ \r\n");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("/:::/  \\:::\\   \\:::\\____\\/:::/  \\:::\\   \\:::|    |/:::/____/     \\:::\\____\\/:::/  \\:::\\   \\:::\\____\\/:::/____/     \\:::|    |/:::/__\\:::\\   \\:::\\____\\\r\n");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("\\::/    \\:::\\  /:::/    /\\::/   |::::\\  /:::|____|\\:::\\    \\      \\::/    /\\::/    \\:::\\  /:::/    /\\:::\\    \\     /:::|____|\\:::\\   \\:::\\   \\::/    /\r\n");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine(" \\/____/ \\:::\\/:::/    /  \\/____|:::::\\/:::/    /  \\:::\\    \\      \\/____/  \\/____/ \\:::\\/:::/    /  \\:::\\    \\   /:::/    /  \\:::\\   \\:::\\   \\/____/ \r\n");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("          \\::::::/    /         |:::::::::/    /    \\:::\\    \\                       \\::::::/    /    \\:::\\    \\ /:::/    /    \\:::\\   \\:::\\    \\     \r\n");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("           \\::::/    /          |::|\\::::/    /      \\:::\\    \\                       \\::::/    /      \\:::\\    /:::/    /      \\:::\\   \\:::\\____\\    \r\n");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("           /:::/    /           |::| \\::/____/        \\:::\\    \\                      /:::/    /        \\:::\\  /:::/    /        \\:::\\   \\::/    /    \r\n");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("          /:::/    /            |::|   |               \\:::\\    \\                    /:::/    /          \\:::\\/:::/    /          \\:::\\   \\/____/     \r\n");
            Console.SetCursorPosition(x, y + 18);
            Console.WriteLine("         /:::/    /             |::|   |                \\:::\\    \\                  /:::/    /            \\::::::/    /            \\:::\\    \\         \r\n");
            Console.SetCursorPosition(x, y + 19);
            Console.WriteLine("        /:::/    /              \\::|   |                 \\:::\\____\\                /:::/    /              \\::::/    /              \\:::\\____\\        \r\n");
            Console.SetCursorPosition(x, y + 20);
            Console.WriteLine("        \\::/    /                \\:|   |                  \\::/    /                \\::/    /                \\::/    /                \\::/    /        \r\n");
            Console.SetCursorPosition(x, y + 21);
            Console.WriteLine("         \\/____/                  \\|___|                   \\/____/                  \\/____/                  \\/____/                  \\/____/");

            x = 1;
            y = 40;
            // Texto Versión
            Console.SetCursorPosition(x, y);
            Console.WriteLine("         __      __            __                __    __    _        \r\n");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|  /    /  )    /  )   -/     / _) (__/      /  /  /  /__)  / )  /__/ \r\n");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|_/ .  (__/ .  (__/ .  /     /__)   /     (_/  /__/  / \\   (__  /  /  ");
        }

        static bool ArcadeWaitForKey()
        {
            int x = 15;
            int y = 27;
            ConsoleKey opc = ConsoleKey.Divide;

            do
            {
                //PRESS ANY KEY
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" ________  ________  _______   ________   ________           ________  ________       ___    ___      ___  __    _______       ___    ___  \r\n");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|\\   __  \\|\\   __  \\|\\  ___ \\ |\\   ____\\ |\\   ____\\         |\\   __  \\|\\   ___  \\    |\\  \\  /  /|    |\\  \\|\\  \\ |\\  ___ \\     |\\  \\  /  /| \r\n");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("\\ \\  \\|\\  \\ \\  \\|\\  \\ \\   __/|\\ \\  \\___|_\\ \\  \\___|_        \\ \\  \\|\\  \\ \\  \\\\ \\  \\   \\ \\  \\/  / /    \\ \\  \\/  /|\\ \\   __/|    \\ \\  \\/  / / \r\n");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine(" \\ \\   ____\\ \\   _  _\\ \\  \\_|/_\\ \\_____  \\\\ \\_____  \\        \\ \\   __  \\ \\  \\\\ \\  \\   \\ \\    / /      \\ \\   ___  \\ \\  \\_|/__   \\ \\    / /  \r\n");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("  \\ \\  \\___|\\ \\  \\\\  \\\\ \\  \\_|\\ \\|____|\\  \\\\|____|\\  \\        \\ \\  \\ \\  \\ \\  \\\\ \\  \\   \\/   / /        \\ \\  \\\\ \\  \\ \\  \\_|\\ \\   \\/   / /   \r\n");
                Console.SetCursorPosition(x, y + 5);
                Console.WriteLine("   \\ \\__\\    \\ \\__\\\\ _\\\\ \\_______\\____\\_\\  \\ ____\\_\\  \\        \\ \\__\\ \\__\\ \\__\\\\ \\__\\__/   / /          \\ \\__\\\\ \\__\\ \\_______\\__/   / /    \r\n");
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine("    \\|__|     \\|__|\\|__|\\|_______|\\_________\\\\_________\\        \\|__|\\|__|\\|__| \\|__|\\____/ /            \\|__| \\|__|\\|_______|\\____/ /     \r\n");
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine("                                 \\|_________\\|_________|                            \\|____|/                                 \\|____|/  ");

                Thread.Sleep(2000);

                Console.SetCursorPosition(x, y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 4);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 5);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 6);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(x, y + 7);
                Console.Write(new string(' ', Console.WindowWidth));

                Thread.Sleep(1000);

                // Lee si se ha pulsado una tecla sin parar el bucle
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    opc = key.Key;
                }

            } while (opc == ConsoleKey.Divide);

            // Borra el texto de Versión
            Console.SetCursorPosition(1, 40);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 41);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 42);
            Console.Write(new string(' ', Console.WindowWidth));

            return true;

            //TransicionSalidaArcade();
            //Thread.Sleep(10000);
            //MenuJuegos();

        }

        static void TransicionSalidaArcade()
        {
            int x = 10;
            int limite = 43;

            for (int y = 1; y < limite; y++)
            {
                //TEXTO ARCADE
                if (y + 1 < limite)
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("          _____                    _____                    _____                    _____                    _____                    _____          \r\n");
                }
                if (y + 2 < limite)
                {
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("         /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\         \r\n");
                }
                if (y + 3 < limite)
                {
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("        /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\        \r\n");
                }
                if (y + 4 < limite)
                {
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("       /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\       \r\n");
                }
                if (y + 5 < limite)
                {
                    Console.SetCursorPosition(x, y + 5);
                    Console.WriteLine("      /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\      \r\n");
                }
                if (y + 6 < limite)
                {
                    Console.SetCursorPosition(x, y + 6);
                    Console.WriteLine("     /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\     \r\n");
                }
                if (y + 7 < limite)
                {
                    Console.SetCursorPosition(x, y + 7);
                    Console.WriteLine("    /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/  \\:::\\    \\        /:::/__\\:::\\    \\        /:::/  \\:::\\    \\        /:::/__\\:::\\    \\    \r\n");
                }
                if (y + 8 < limite)
                {
                    Console.SetCursorPosition(x, y + 8);
                    Console.WriteLine("   /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\      /:::/    \\:::\\    \\      /::::\\   \\:::\\    \\      /:::/    \\:::\\    \\      /::::\\   \\:::\\    \\   \r\n");
                }
                if (y + 9 < limite)
                {
                    Console.SetCursorPosition(x, y + 9);
                    Console.WriteLine("  /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\    /:::/    / \\:::\\    \\    /::::::\\   \\:::\\    \\    /:::/    / \\:::\\    \\    /::::::\\   \\:::\\    \\  \r\n");
                }
                if (y + 10 < limite)
                {
                    Console.SetCursorPosition(x, y + 10);
                    Console.WriteLine(" /:::/\\:::\\   \\:::\\    \\  /:::/\\:::\\   \\:::\\____\\  /:::/    /   \\:::\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/    /   \\:::\\ ___\\  /:::/\\:::\\   \\:::\\    \\ \r\n");
                }
                if (y + 11 < limite)
                {
                    Console.SetCursorPosition(x, y + 11);
                    Console.WriteLine("/:::/  \\:::\\   \\:::\\____\\/:::/  \\:::\\   \\:::|    |/:::/____/     \\:::\\____\\/:::/  \\:::\\   \\:::\\____\\/:::/____/     \\:::|    |/:::/__\\:::\\   \\:::\\____\\\r\n");
                }
                if (y + 12 < limite)
                {
                    Console.SetCursorPosition(x, y + 12);
                    Console.WriteLine("\\::/    \\:::\\  /:::/    /\\::/   |::::\\  /:::|____|\\:::\\    \\      \\::/    /\\::/    \\:::\\  /:::/    /\\:::\\    \\     /:::|____|\\:::\\   \\:::\\   \\::/    /\r\n");
                }
                if (y + 13 < limite)
                {
                    Console.SetCursorPosition(x, y + 13);
                    Console.WriteLine(" \\/____/ \\:::\\/:::/    /  \\/____|:::::\\/:::/    /  \\:::\\    \\      \\/____/  \\/____/ \\:::\\/:::/    /  \\:::\\    \\   /:::/    /  \\:::\\   \\:::\\   \\/____/ \r\n");
                }
                if (y + 14 < limite)
                {
                    Console.SetCursorPosition(x, y + 14);
                    Console.WriteLine("          \\::::::/    /         |:::::::::/    /    \\:::\\    \\                       \\::::::/    /    \\:::\\    \\ /:::/    /    \\:::\\   \\:::\\    \\     \r\n");
                }
                if (y + 15 < limite)
                {
                    Console.SetCursorPosition(x, y + 15);
                    Console.WriteLine("           \\::::/    /          |::|\\::::/    /      \\:::\\    \\                       \\::::/    /      \\:::\\    /:::/    /      \\:::\\   \\:::\\____\\    \r\n");
                }
                if (y + 16 < limite)
                {
                    Console.SetCursorPosition(x, y + 16);
                    Console.WriteLine("           /:::/    /           |::| \\::/____/        \\:::\\    \\                      /:::/    /        \\:::\\  /:::/    /        \\:::\\   \\::/    /    \r\n");
                }
                if (y + 17 < limite)
                {
                    Console.SetCursorPosition(x, y + 17);
                    Console.WriteLine("          /:::/    /            |::|   |               \\:::\\    \\                    /:::/    /          \\:::\\/:::/    /          \\:::\\   \\/____/     \r\n");
                }
                if (y + 18 < limite)
                {
                    Console.SetCursorPosition(x, y + 18);
                    Console.WriteLine("         /:::/    /             |::|   |                \\:::\\    \\                  /:::/    /            \\::::::/    /            \\:::\\    \\         \r\n");
                }
                if (y + 19 < limite)
                {
                    Console.SetCursorPosition(x, y + 19);
                    Console.WriteLine("        /:::/    /              \\::|   |                 \\:::\\____\\                /:::/    /              \\::::/    /              \\:::\\____\\        \r\n");
                }
                if (y + 20 < limite)
                {
                    Console.SetCursorPosition(x, y + 20);
                    Console.WriteLine("        \\::/    /                \\:|   |                  \\::/    /                \\::/    /                \\::/    /                \\::/    /        \r\n");
                }
                if (y + 21 < limite)
                {
                    Console.SetCursorPosition(x, y + 21);
                    Console.WriteLine("         \\/____/                  \\|___|                   \\/____/                  \\/____/                  \\/____/                  \\/____/");
                }
                Thread.Sleep(30);
                Console.SetCursorPosition(x, y + 1);
                Console.Write(new string(' ', Console.WindowWidth));
            }
        }
    }
}