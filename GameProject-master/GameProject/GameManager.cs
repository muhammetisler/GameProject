using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        public GameManager()
        {
            gameList = new List<Game>();
        }
        private List<Game> gameList;

        public void ShowGames()
        {
            foreach (Game game in gameList)
            {
                Console.WriteLine(game.GameName);
            }
        }
        public Game AddGame(string gameName, int Price)
        {
            Game newGame = new Game(gameName, Price);
            Console.WriteLine("Oyun eklendi.");
            gameList.Add(newGame);
            return newGame;
        }

        public void DeleteGame(string gameName)
        {
            bool isFound = false;


            for (int i = 0; i < gameList.Count; i++)
            {
                if (gameList[i].GameName == gameName)
                {
                    gameList.RemoveAt(i);
                    Console.WriteLine("Oyun listeden kaldırıldı");
                    isFound = true;

                }
            }

            if (isFound == false)
            {
                Console.WriteLine("Oyun bulunamadı.");
            }




        }

        public void BuyGame(Player player, Game game,ICampaignService campaignService)
        {
            player.gamesList.Add(game);
            Console.WriteLine(player.Name +" "+ game.GameName + " oyununu satın aldı" );
            campaignService.CalculateNewPrice(game);

        }
    }

}
