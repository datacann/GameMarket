using System;

namespace GameMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntity player1 = new Player { Id = 1, Name = "atacan", Surname = "erdoğan", Birthday = "1996", NationalityId = "1111", NickName = "datacan" };
            IEntity player2 = new Player { Id = 2, Name = "samet", Surname = "yıldız", Birthday = "1999", NationalityId = "2222", NickName = "sameddd" };
            IEntity player3 = new Player { Id = 3, Name = "kasım", Surname = "can", Birthday = "1997", NationalityId = "3333", NickName = "kassssım" };

            IEntityServices playerManageer = new PlayerManageer(new MernisValidateManager());
            playerManageer.Add(player1);
            playerManageer.Add(player2);
            playerManageer.Add(player3);

            Console.WriteLine("*****************************\nTüm oyuncular");

            IEntity game1 = new Game { Id = 1, Name = "A.C valhalla", PublisherName = "ubisoft", Price = 200, stock = 500 };
            IEntity game2 = new Game { Id = 2, Name = "CyberPunk 2077", PublisherName = "CD Project Red", Price = 502, stock = 200 };
            IEntity game3 = new Game { Id = 3, Name = "gta vice city", PublisherName = "rockstar", Price = 25, stock = 500 };

            IEntityServices gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            //steam oyun alma

            ISaleService steam = new SteamManager();
            steam.Buy(game3, player1);

            // epic games den oyun alma

            ISaleService epic = new EpicGmaesManager();
            epic.Buy(player2, game2);

            //kampanyalar

            ICampaignServices summer = new SummerCampaignManager();
            summer.Add(game1);

            ICampaignServices year = new ChristmasCampaignManager();
            year.Add(game3);












        }
    }
}
