using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipCrash.UI.Entities.DefensiveUnits.Bullets;
using ShipCrash.UI.Entities.Enemies;
using ShipCrash.UI.Managers;

namespace ShipCrash.UI.Entities.DefensiveUnits
{
    public class BasicShootingTower : DefensiveUnit
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/turtle-cannon.png");
        private const int PRICE = 10;
        public BasicShootingTower() : base(PRICE, imageURI)
        {
            LifePoints = 1;
        }

        public BasicShootingTower(int width) : base(PRICE, imageURI, width)
        {
            LifePoints = 1;
        }

        protected override void OnShoot(object sender, EventArgs e)
        {
            // TODO : Remove the manage properly the DestroyedHandler dependency, and the Adding to the canvas ( AddHandler )
            Trace.WriteLine("On shoot");
            base.Shoot(new BasicBullet(CurrentTarget));
        }
    }
}
