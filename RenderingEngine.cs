using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Srarted");
            Console.WriteLine("Drawing Visuals...");
        }

        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stoped");
        }
    }
}
