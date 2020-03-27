using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator.Entities
{
    public class CalculatorMemory
    {
        private readonly Stack<decimal> memory;
        private ListBox memoryContainer;

        public CalculatorMemory(ListBox memoryContainer)
        {
            this.memory = new Stack<decimal>();
            this.memoryContainer = memoryContainer;
        }

        public void Clear()
        {
            this.memory.Clear();
        }

        public void MemorySubstract(decimal number)
        {
            var currentNumber = memory.Pop();
            currentNumber -= number;
            memory.Push(currentNumber);
            this.memoryContainer.Items[0] = memory.Peek();
        }

        public void MemoryAddition(decimal number)
        {
            var currentNumber = memory.Pop();
            currentNumber += number;
            memory.Push(currentNumber);
            this.memoryContainer.Items[0] = memory.Peek();
        }

        public decimal MemoryRecall => memory.Peek();

        public void MemoryStore(decimal number)
        {
            this.memory.Push(number);
            this.memoryContainer.Items.Insert(0, memory.Peek());
        }
    }
}
