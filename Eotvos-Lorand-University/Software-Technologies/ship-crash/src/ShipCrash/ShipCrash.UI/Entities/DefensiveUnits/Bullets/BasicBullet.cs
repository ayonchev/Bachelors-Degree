using ShipCrash.UI.Entities.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCrash.UI.Entities.DefensiveUnits.Bullets
{
    public class BasicBullet : Bullet
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/cannon-ball.png");
        public BasicBullet(Enemy target) : base(target, imageURI)
        {
            AttackPoints = 1;
            Duration = TimeSpan.FromMilliseconds(1500);
        }
    }
}
