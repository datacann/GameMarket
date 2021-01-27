using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class SteamManager : ISaleService
    {
        public void Buy(IEntity game, IEntity player)
        {
            Console.WriteLine(player.Name + "isimli oyuncu" + game.Name + "isimli oyunu Steam üzerinden satın aldı");
        }
    }
}
