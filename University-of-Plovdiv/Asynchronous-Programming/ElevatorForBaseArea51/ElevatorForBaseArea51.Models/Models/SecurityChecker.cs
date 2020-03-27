using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorForBaseArea51.Data.Models
{
    public class SecurityChecker
    {
        public bool CanDoorOpen(SecurityLevel securityLevel, Floor floor)
        {
            if ((int)securityLevel == (int)floor ||
                (int)securityLevel > (int)floor ||
                securityLevel == SecurityLevel.TopSecret)
                return true;

            return false;
        }
    }
}
