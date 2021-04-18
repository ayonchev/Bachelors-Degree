using ShipCrash.UI.Entities.DefensiveUnits;
using ShipCrash.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShipCrash.UI.Entities.Enemies
{
    public class BasicEnemy : Enemy
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/ship.png");
        public BasicEnemy(List<DefensiveUnit> targets) : base(targets, imageURI)
        {
            AttackPoints = 5;
            LifePoints = 1;
            Duration = TimeSpan.FromMilliseconds(8000);
        }
    }
}
