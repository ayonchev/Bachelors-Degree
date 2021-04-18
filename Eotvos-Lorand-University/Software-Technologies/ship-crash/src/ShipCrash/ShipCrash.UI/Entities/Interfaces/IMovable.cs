using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace ShipCrash.UI.Entities.Interfaces
{
    public interface IMovable
    {
        Storyboard MovementAnimation { get; }
        void Start(Point targetCoordinates, TimeSpan duration);
        void Pause();
        void Resume();
        void PositionChanged(object sender, EventArgs e);
    }
}
