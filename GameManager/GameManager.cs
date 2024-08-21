using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerApp
{
    internal class GameManager
    {
        private static GameManager gameManager = new GameManager();
        private  IGameStrategy game;

        private GameManager()
        {
            game = new GuessTheNumber();
        }

        public void setGame(IGameStrategy game)
        {
            this.game = game;
        }

        public static GameManager GetGameManager()
        {
            if(gameManager is null) 
                gameManager = new GameManager();
            return gameManager;
        }
        public void RunGame()
        {
            game.Run();
        }
    }
}
