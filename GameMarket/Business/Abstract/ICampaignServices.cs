using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    interface ICampaignServices
    {
        void Add(IEntity game);
        void delete(IEntity game);
        void update(IEntity game);
    }
}
