using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpaceInvaders
{
    internal class Header
    {

        public void Create()
        {
            PrintHeader(0, 3);
        }

        public void Update(int score, int hp)
        {
            PrintHeader(score, hp);
        }

        public void PrintHeader(int score, int hp)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("______________________________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("   _____  _____ ____  _____  ______     \r\n");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  / ____|/ ____/ __ \\|  __ \\|  ____|  _ \r\n");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(" | (___ | |   | |  | | |__) | |__    (_)\r\n");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("  \\___ \\| |   | |  | |  _  /|  __|      \r\n");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("  ____) | |___| |__| | | \\ \\| |____   _ \r\n");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine(" |_____/ \\_____\\____/|_|  \\_\\______| (_)");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("______________________________________________________________________________________________________________________________________________");

            //AQUI LA LÓGICA DEL SCORE


            Console.SetCursorPosition(0, 8);
            //Console.WriteLine("  _    _ _____      \r\n | |  | |  __ \\   _ \r\n | |__| | |__) | (_)\r\n |  __  |  ___/     \r\n | |  | | |       _ \r\n |_|  |_|_|      (_)");
            Console.WriteLine("  _    _ _____      \r\n");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine(" | |  | |  __ \\   _ \r\n");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine(" | |__| | |__) | (_)\r\n");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine(" |  __  |  ___/     \r\n");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" | |  | | |       _ \r\n");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine(" |_|  |_|_|      (_)");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("______________________________________________________________________________________________________________________________________________");

            //AQUI LA LÓGICA DE LA VIDA

            switch(hp)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1: 
                    Console.WriteLine();
                    break;
                case 2: 
                    Console.WriteLine();
                    break; 
                case 3: 
                    Console.WriteLine();
                    break;
            }

        }
    }    
}
