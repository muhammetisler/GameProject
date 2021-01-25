using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Player
    {
        public Player(string name, string surName, string tcNo, string birthDate)
        {
            this.Name = name;
            this.Surname = surName;
            this.TcNo = tcNo;
            this.BirthDate = birthDate;
            gamesList = new List<Game>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string BirthDate { get; set; }
        public List<Game> gamesList;
         
    }
}
