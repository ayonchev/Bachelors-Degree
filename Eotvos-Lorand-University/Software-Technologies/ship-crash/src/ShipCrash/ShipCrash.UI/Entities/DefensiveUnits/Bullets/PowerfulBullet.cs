using ShipCrash.UI.Entities.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCrash.UI.Entities.DefensiveUnits.Bullets
{
    public class PowerfulBullet : Bullet
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/powerful-cannon-ball.png");
        private const int ATTACK_POINTS = 15;
        public PowerfulBullet(Enemy target) : base(target, imageURI)
        {
            AttackPoints = ATTACK_POINTS;
            Duration = TimeSpan.FromMilliseconds(1500);
        }
    }
}
