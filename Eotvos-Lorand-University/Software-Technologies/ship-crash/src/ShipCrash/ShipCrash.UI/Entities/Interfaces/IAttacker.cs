using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCrash.UI.Entities.Interfaces
{
    public interface IAttacker
    {
        int AttackPoints { get; }
        void Attack(IHittable hittable);
    }
}
