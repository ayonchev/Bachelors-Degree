using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCrash.UI.Entities.DefensiveUnits.Bullets;
using ShipCrash.UI.Entities.Enemies;
using ShipCrash.UI.Managers;

namespace ShipCrash.UI.Entities.DefensiveUnits
{
    public class PowerfulShootingTower : DefensiveUnit
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/powerful-turtle-cannon.png");
        private const int PRICE = 100;

        public PowerfulShootingTower() : base(PRICE, imageURI)
        {
            LifePoints = 1;
        }

        public PowerfulShootingTower(int width) : base(PRICE, imageURI, width)
        {
            LifePoints = 1;
        }

        protected override void OnShoot(object sender, EventArgs e)
        {
            base.Shoot(new PowerfulBullet(CurrentTarget));
        }
    }
}
