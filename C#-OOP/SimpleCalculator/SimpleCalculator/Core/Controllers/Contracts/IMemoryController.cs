using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Core.Controllers.Contracts
{
    interface IMemoryController
    {
        decimal MemoryRecall { get; }

        void ClearMemory();

        void MemorySubstract(decimal currentResult);

        void MemoryAddition(decimal currentResult);

        void MemoryStore(decimal currentResult);
    }
}
