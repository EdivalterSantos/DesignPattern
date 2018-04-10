using System.Diagnostics;

namespace FactoryPattern
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double AmtDemage { get; set; }

        public void FollowHeroShip()
        {
            Debug.WriteLine(Name + " Is following the hero");
        }

        public void DisplayEnemyShip()
        {
            Debug.WriteLine(Name + " Is on the scree");
        }

        public void EnemyShipShoots()
        {
            Debug.WriteLine(Name + " attacks and does " + AmtDemage + " demage ");
        }
    }
}
