using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class ChristmasCampaignManager : ICampaignServices
    {
        public void Add(IEntity game)
        {
            Console.WriteLine(game.Name + "isimli oyun yılbaşı indirimi listesine eklenmiştir");
        }

        public void delete(IEntity game)
        {
            Console.WriteLine(game.Name + "isimli oyun yılbaşı indirimi listesinden kaldırılmıştır.");
        }

        public void update(IEntity game)
        {
            Console.WriteLine(game.Name + "isimli oyun yılbaşı indirimi listesinde güncelleme yapılmıştır.");
        }
    }
}
