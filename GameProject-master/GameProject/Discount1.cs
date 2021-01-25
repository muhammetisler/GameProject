using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Discount1 : ICampaignService
    {
        public void CalculateNewPrice(Game game)
        {
            int oldPrice = game.Price;
            double newPrice = game.Price * 0.9;
            
            Console.WriteLine("Eski Fiyat : {0} İndirimli Fiyatınız : {1}",oldPrice,newPrice);
        }
    }
}
