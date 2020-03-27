using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Core.Controllers.Contracts
{
    interface IHistoryController
    {
        void Store(string expression, string result);

        void Clear();
    }
}
