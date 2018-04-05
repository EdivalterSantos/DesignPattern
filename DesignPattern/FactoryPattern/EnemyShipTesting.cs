using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class EnemyShipTesting
    {
        static void Main(string[] args)
        {
            EnemyShipFactory factory = new EnemyShipFactory();

            Console.WriteLine("What tipe of ship? ( U / R )");
            var lire = Console.ReadLine();

            factory.MakeEnemyShip(lire);

            DoStuffEnemy(factory.MakeEnemyShip(lire));
        }

        private static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}
