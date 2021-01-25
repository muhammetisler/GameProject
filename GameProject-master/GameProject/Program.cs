using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            Player Ahmet = playerManager.CreateAccount("Ahmet Can", "Korkmaz", "1", "1991");
            Player Serkan = playerManager.CreateAccount("Serkan", "Uludağ", "2", "1993");
            Player Alper = playerManager.CreateAccount("Alper", "Uslu", "3", "1993");

            playerManager.DeleteAccount("3");
            playerManager.DeleteAccount("3");

            playerManager.ShowPlayers();

            GameManager gameManager = new GameManager();
            Game farcry = gameManager.AddGame("Far Cry", 300);
            Game counterStrike = gameManager.AddGame("Counter Strike", 200);
            Game loL = gameManager.AddGame("LoL", 100);


            Discount1 tenPercent = new Discount1(); 
            gameManager.DeleteGame("LoL");
            gameManager.ShowGames();
            gameManager.BuyGame(Ahmet,farcry,tenPercent);
            tenPercent.CalculateNewPrice(counterStrike);
            

            playerManager.ShowGameList(Ahmet);
        }
    }
}
