
namespace FactoryPattern
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string theEnemy)
        {

            if (theEnemy.ToUpper().Contains("U"))
            {
                return new UfoEnemyShip();
            }

            if (theEnemy.ToUpper().Contains("R"))
            {
                return new RockerEnemyShip();
            }

            return theEnemy.ToUpper().Contains("B") ? new BigEnemyShip() : null;
        }

    }


}
