using System;
using System.Collections.Generic;
using System.Text;

namespace ShipCrash.UI.Entities
{
    public class IslandTower : BaseEntity
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/island-tower.png");
        public IslandTower(int width = 40) : base(imageURI, width)
        {
        }
    }
}
