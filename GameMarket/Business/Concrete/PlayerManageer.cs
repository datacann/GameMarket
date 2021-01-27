using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class PlayerManageer : IEntityServices
    {
        private ICheckServices _checkService;
        public PlayerManageer(ICheckServices checkServices)
        {
            _checkService = checkServices;
        }
        public void Add(IEntity entity)
        {
            if(_checkService.Validate(entity))
            {
                Console.WriteLine(entity.Name + "isimli oyuncu sisteme eklendi");
            }
            else
            {
                Console.WriteLine(entity.Name + "isimli oyuncunun bilgileri yanlış");
            }
        }

        public void delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + "isimli oyuncunun kaydı başarıyla silinli");
        }

        public void update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
