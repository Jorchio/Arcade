using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceInvaders
{
    internal class Disparo : GameObject
    {
        public int x { get; set; }
        public int y { get; set; }

        public Disparo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Update()
        {
            // Mirar como conseguir el player
            // La bala puede tener un puntero al player y comprobar la posicion para las colisiones
        }
    }
}
