using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class SummerCampaignManager : ICampaignServices
    {
        public void Add(IEntity game)
        {
            Console.WriteLine(game.Name + "isimli oyun indirim listesine eklenmiştir");
        }

        public void delete(IEntity game)
        {
            Console.WriteLine(game.Name + "isimli oyun indirim listesinden kaldırılmıştır.");
        }

        public void update(IEntity game)
        {
            Console.WriteLine(game.Name + "isimli oyununun fiyatı güncellenmiştir.");
        }
    }
}
