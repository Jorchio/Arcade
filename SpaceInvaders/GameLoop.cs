using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class GameLoop
    {
        private Game game;
        public bool running { get; private set; }
        public int multiplicador;
        
        public GameLoop(int multiplicador)
        {
            this.multiplicador = multiplicador;
        }

        public void Load()
        {
           // game = new Game();
        }

        public async void Start()
        {
            DateTime _previousGameTime = DateTime.Now;

            while (running)
            {
                TimeSpan GameTime = DateTime.Now - _previousGameTime;
                _previousGameTime = _previousGameTime + GameTime;
                await Task.Delay(8);
            }
        }
    }
}
