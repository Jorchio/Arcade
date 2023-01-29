using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceInvaders
{
    internal class Player : GameObject
    {
        public int x { get; set; }
        public static int maxX { get; set; }
        public static int initialX { get; set; }
        public int y { get; set; }
        public static int maxY { get; set; }
        public static int initialY { get; set; }
        public int hp { get; set; }

        public List<Disparo> disparos { get; set; }

        public override void Initialize()
        {
            initialX = 42; 
            initialY = 50;
            x = initialX;
            y = initialY;
            maxX = 83;
            maxY = 50;
            hp = 100;
        }

        public void ResetPosition()
        {
            x = initialX;
            y = initialY;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("/[T]\\");
        }

        public void Create()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("/[T]\\");
        }

        public override void Update()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("/[T]\\");
        }

        public void MoverDerecha()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
            if ( x < maxX)
            {
                x++;
                Update();
            }
        }

        public void MoverIzquierda()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
            if (x > 0 )
            {
                x--;
                Update();
            }
        }

        public void Disparar()
        {
            disparos.Add(new Disparo(x, y));
            Console.SetCursorPosition(x, y);
        }
    }
}
