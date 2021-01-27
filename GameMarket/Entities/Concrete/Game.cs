using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class Game: IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public int Price { get; set; }
        public int stock { get; set; }
    }
}
