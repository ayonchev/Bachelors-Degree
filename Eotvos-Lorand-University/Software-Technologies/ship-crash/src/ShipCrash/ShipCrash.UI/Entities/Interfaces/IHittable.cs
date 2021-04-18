﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCrash.UI.Entities.Interfaces
{
    public interface IHittable
    {
        int LifePoints { get; }
        void OnHit(IAttacker attacker);
    }
}
