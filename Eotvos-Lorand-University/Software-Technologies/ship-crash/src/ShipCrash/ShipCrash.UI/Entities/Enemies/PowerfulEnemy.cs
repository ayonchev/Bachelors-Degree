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
    public class PowerfulEnemy : Enemy
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/powerful-ship.png");
        public PowerfulEnemy(List<DefensiveUnit> targets) : base(targets, imageURI)
        {
            AttackPoints = 20;
            LifePoints = 10;
            Duration = TimeSpan.FromMilliseconds(6000);
        }
    }
}
