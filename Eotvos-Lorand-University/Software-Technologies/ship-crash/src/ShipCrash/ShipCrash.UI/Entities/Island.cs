using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ShipCrash.UI.Entities.Interfaces;
using ShipCrash.UI.Managers;

namespace ShipCrash.UI.Entities
{
    public class Island : BaseEntity
    {
        private static Uri imageURI = new Uri("pack://application:,,,/ShipCrash.UI;component/Images/island.png");
        private const int DEFAULT_WIDTH = 150;
        public List<IslandTower> Towers { get; private set; }
        public event EventHandler LifePointsChanged;

        public Island(int width = DEFAULT_WIDTH) : base(imageURI, width)
        {
            LifePoints = 3;
            Towers = new List<IslandTower>(LifePoints);
            Control.Stretch = System.Windows.Media.Stretch.Uniform;
            Control.StretchDirection = StretchDirection.Both;
        }

        //TODO: Make the method more generic.
        public void CreateTowers()
        {
            IslandTower firstTower = new IslandTower();
            IslandTower secondTower = new IslandTower();
            IslandTower thirdTower = new IslandTower();

            firstTower.SetCoordinates(new System.Windows.Point(this.Rect.X + 20, this.Rect.Y + 20));
            secondTower.SetCoordinates(new System.Windows.Point(this.Rect.X + 90, this.Rect.Y + 20));
            thirdTower.SetCoordinates(new System.Windows.Point(this.Rect.X + 50, this.Rect.Y + 50));
            Towers.AddRange(new[] { firstTower, secondTower, thirdTower });

            if (LifePointsChanged != null)
                LifePointsChanged.Invoke(this, null);
        }

        public override void OnHit(IAttacker attacker)
        {
            LifePoints--;
            IslandTower currentTower = Towers[0];
            currentTower.OnHit(attacker);
            Towers.Remove(currentTower);

            if (LifePointsChanged != null)
                LifePointsChanged.Invoke(this, null);
        }
    }
}
