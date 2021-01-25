using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager
    {
        public PlayerManager()
        {
            playerList = new List<Player>();
        }

        private List<Player> playerList; 

        public void ShowPlayers()
        {
            foreach (Player player in playerList)
            {
                Console.WriteLine(player.Name);
            }
        }
        public Player CreateAccount(string name, string surName, string tcNo, string birthDate)
        {
            Player newPlayer = new Player(name,surName,tcNo,birthDate);
            Console.WriteLine("Yeni Oyuncu Oluşturuldu.");
            playerList.Add(newPlayer);
            Console.WriteLine("Yeni Oyuncu Listeye Eklendi.");
            return newPlayer;
        }

        public void DeleteAccount(string tcNo)
        {
            bool isFound = false;
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].TcNo == tcNo)
                {
                    playerList.RemoveAt(i);
                    Console.WriteLine("Oyuncu listeden kaldırıldı");
                    isFound = true;

                }


            }

            if (isFound == false)
            {
                Console.WriteLine("Oyuncu bulunamadı.");
            }
        }
        
        public void ShowGameList (Player player)
        {
            for (int i = 0; i < player.gamesList.Count; i++)
            {
                Console.WriteLine(player.gamesList[i].GameName);
            }
        }
        public void LogIn(string Name, string SurName, string TcNo, string BirthDate)
        {

            
        }
    }

}
