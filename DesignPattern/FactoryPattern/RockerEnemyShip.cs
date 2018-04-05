using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public class RockerEnemyShip : EnemyShip
    {
        public RockerEnemyShip()
        {
            Name = " Rocker Enemy Ship";
            AmtDemage = (10.00);
        }
    }
}
