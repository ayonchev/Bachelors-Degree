using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ShipCrash.UI.Entities.DefensiveUnits;
using ShipCrash.UI.Managers;

namespace ShipCrash.UI.Entities.Enemies
{
    public class FastEnemy : Enemy
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/fast-ship.png");
        public FastEnemy(List<DefensiveUnit> targets) : base(targets, imageURI)
        {
            AttackPoints = 10;
            LifePoints = 5;
            Duration = TimeSpan.FromMilliseconds(4000);
        }
    }
}
