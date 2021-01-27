using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class GameManager : IEntityServices
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + "oyunu sisteme yüklendi");
        }

        public void delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + "oyunu sistemden silindi");
        }

        public void update(IEntity entity)
        {
            Console.WriteLine(entity.Name + "oyunu güncellendi");
        }
    }
}
