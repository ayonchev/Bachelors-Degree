namespace SimpleCalculator.Core.Controllers
{
    using System;
    using System.Windows.Forms;
    using SimpleCalculator.Core.Controllers.Contracts;

    public class MemoryController : IMemoryController
    {
        private ListBox memory;

        public MemoryController(ListBox memory)
        {
            this.memory = memory;
        }

        public decimal MemoryRecall => Convert.ToDecimal(memory.Items[0]);

        public void ClearMemory()
        {
            this.memory.Items.Clear();
        }

        public void MemorySubstract(decimal currentResult)
        {
            bool emptyMemory = Validator.ValidateIsMemoryEmpty(memory);

            if (!emptyMemory)
            {
                memory.Items[0] = MemoryRecall - currentResult;
            }
        }

        public void MemoryAddition(decimal currentResult)
        {
            bool emptyMemory = Validator.ValidateIsMemoryEmpty(memory);

            if (!emptyMemory)
            {
                memory.Items[0] = MemoryRecall + currentResult;
            }
        }

        public void MemoryStore(decimal currentResult)
        {
            memory.Items.Insert(0, currentResult);
        }
    }
}
