using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Game
    {
        public int multiplicador { get; set; }
        public int velocidad { get; set; }
        public bool running { get; set; }
        public int score { get; set; }
        public GameObjectManager objMgr = new GameObjectManager();
        public Header header = new Header();
        // Puntero a clase player
        public Player player = new Player();
        public ConsoleKeyInfo opc { get; set; }

        public Game() 
        {
            //player = objMgr.add
        }

        public void Load()
        {
            //velocidad = multiplicador;

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.SetWindowSize(88, 55);
            //Console.SetWindowPosition(50,40);
            //GameLoop gameLoop = new GameLoop(multiplicador);
        }

        public void CountDown()
        {
            //TRES
            Console.Clear();
            Console.SetCursorPosition(40, 22);
            Console.WriteLine("  ____  \r\n");
            Console.SetCursorPosition(40, 23);
            Console.WriteLine(" |___ \\ \r\n");
            Console.SetCursorPosition(40, 24);
            Console.WriteLine("   __) |\r\n");
            Console.SetCursorPosition(40, 25);
            Console.WriteLine("  |__ < \r\n");
            Console.SetCursorPosition(40, 26);
            Console.WriteLine("  ___) |\r\n");
            Console.SetCursorPosition(40, 27);
            Console.WriteLine(" |____/");
            Thread.Sleep(1000);
            //DOS
            Console.Clear();
            Console.SetCursorPosition(40, 22);
            Console.WriteLine("  ___  \r\n");
            Console.SetCursorPosition(40, 23);
            Console.WriteLine(" |__ \\ \r\n");
            Console.SetCursorPosition(40, 24);
            Console.WriteLine("    ) |\r\n");
            Console.SetCursorPosition(40, 25);
            Console.WriteLine("   / / \r\n");
            Console.SetCursorPosition(40, 26);
            Console.WriteLine("  / /_ \r\n");
            Console.SetCursorPosition(40, 27);
            Console.WriteLine(" |____|");
            Thread.Sleep(1000);
            //UNO
            Console.Clear();
            Console.SetCursorPosition(40, 22);
            Console.WriteLine("  __ \r\n");
            Console.SetCursorPosition(40, 23);
            Console.WriteLine(" /_ |\r\n");
            Console.SetCursorPosition(40, 24);
            Console.WriteLine("  | |\r\n");
            Console.SetCursorPosition(40, 25);
            Console.WriteLine("  | |\r\n");
            Console.SetCursorPosition(40, 26);
            Console.WriteLine("  | |");
            Console.SetCursorPosition(40, 27);
            Console.WriteLine("  |_|");
            Thread.Sleep(1000);
            //START
            Console.Clear();
            Console.SetCursorPosition(18, 22);
            Console.WriteLine("  _ _ _  _____ _______       _____ _______ _ _ _ \r\n");
            Console.SetCursorPosition(18, 23);
            Console.WriteLine(" | | | |/ ____|__   __|/\\   |  __ \\__   __| | | |\r\n");
            Console.SetCursorPosition(18, 24);
            Console.WriteLine(" | | | | (___    | |  /  \\  | |__) | | |  | | | |\r\n");
            Console.SetCursorPosition(18, 25);
            Console.WriteLine(" | | | |\\___ \\   | | / /\\ \\ |  _  /  | |  | | | |\r\n");
            Console.SetCursorPosition(18, 26);
            Console.WriteLine(" |_|_|_|____) |  | |/ ____ \\| | \\ \\  | |  |_|_|_|\r\n");
            Console.SetCursorPosition(18, 27);
            Console.WriteLine(" (_|_|_)_____/   |_/_/    \\_\\_|  \\_\\ |_|  (_|_|_)");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public void Start()
        {
            player.Create();
            header.Create();
            running = true;

            while (running == true)
            {
                opc = Console.ReadKey();

                switch (opc.Key)
                {
                    case ConsoleKey.RightArrow:
                        player.MoverDerecha();
                        break;
                    case ConsoleKey.D:
                        player.MoverDerecha();
                        break;
                    case ConsoleKey.LeftArrow:
                        player.MoverIzquierda();
                        break;
                    case ConsoleKey.A:
                        player.MoverIzquierda();
                        break;
                    case ConsoleKey.UpArrow:
                        player.Disparar();
                        break;
                    case ConsoleKey.W:
                        player.Disparar();
                        break;
                    case ConsoleKey.Escape:
                        Pause();
                        break;
                    default:
                        //game.Update();
                        break;
                }
            }
        }

        public void Update()
        {
            Thread.Sleep(1000);
        }

        public void Pause()
        {
            running = false;
        }

        public void Stop()
        {
            running = false;
        }
    }
}
