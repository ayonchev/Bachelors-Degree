using ShipCrash.UI.Entities.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCrash.UI.Entities.DefensiveUnits.Bullets
{
    public class FastBullet : Bullet
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/fast-cannon-ball.png");
        public FastBullet(Enemy target) : base(target, imageURI)
        {
            AttackPoints = 5;
            Duration = TimeSpan.FromMilliseconds(500);
        }
    }
}
