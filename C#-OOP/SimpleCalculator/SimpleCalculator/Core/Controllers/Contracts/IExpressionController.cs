using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Core.Controllers.Contracts
{
    public interface IExpressionController
    {
        //void TypeExpression(string text);
        void EnterNumber(string number);

        void EnterDecimalSeparator(string decSeparator);

        void EnterOperation(string operation);

        void EnterStartingBracket(string startingBracket);

        void EnterEndingBracket(string endingBracket);

        void Clear();
        void ClearEntry();
        void ClearLast();

        void DisplayResult();

        decimal GetCurrentResult();

        void EnterMemoryElement(decimal memoryElement);
    }
}
