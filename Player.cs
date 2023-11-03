using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Player
    {
        public string PleyerName { get; set; }

       
        public Player(string name)
        {
            this.PleyerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID: {PleyerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PleyerName}");
        }
        
    }
}
