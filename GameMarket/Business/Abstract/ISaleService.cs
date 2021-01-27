using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    interface ISaleService
    {
        void Buy(IEntity game, IEntity player);
    }
}
