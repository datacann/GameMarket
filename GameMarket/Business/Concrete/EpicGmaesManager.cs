using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class EpicGmaesManager : ISaleService
    {
        public void Buy(IEntity game, IEntity player)
        {
            Console.WriteLine(player.Name + "isimli oyuncu" + game.Name + "isimli oyunu Epic Games üzerinden satın aldı");
        }
    }
}
