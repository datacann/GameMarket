using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class Player : IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string Birthday { get; set; }
        public string NickName { get; set; }

    }
}
