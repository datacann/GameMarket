using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    interface IEntityServices
    {
        void Add(IEntity entity);
        void delete(IEntity entity);
        void update(IEntity entity);
    }
}
