using ShipCrash.UI.Entities.Enemies;
using ShipCrash.UI.Entities.DefensiveUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShipCrash.UI.Managers.Interfaces
{
    public interface IGameManager
    {
        BuyManager BuyManager { get; }
        int LifePoints { get; }
        int ExperiencePoints { get; }
        void Start();
        void Pause();
        void Resume();
        void Restart();
        void AddDefensiveUnit(Point position);
        Enemy CreateEnemy();
    }
}
