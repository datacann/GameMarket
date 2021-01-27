using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
     class MernisValidateManager : ICheckServices
    {       
        public bool Validate(IEntity entity)
        {
            Console.WriteLine("oyuncu bilgileri doğru");
            return true;
        }

    }
}
