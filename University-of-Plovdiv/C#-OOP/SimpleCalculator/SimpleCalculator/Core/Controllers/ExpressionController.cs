namespace SimpleCalculator.Core.Controllers
{
    using System.Windows.Forms;
    using SimpleCalculator.Core.Controllers.Contracts;
    using SimpleCalculator.Entities;

    public class ExpressionController : IExpressionController
    {
        private ICalculator calculator;
        private TextBox result;
        private TextBox expression;

        public ExpressionController(ICalculator calculator, TextBox result, TextBox expression)
        {
            this.calculator = calculator;
            this.result = result;
            this.expression = expression;
        }

        //All of the typing methods
        public void EnterNumber(string number)
        {
            Validator.ValidateNumber(result, expression);

            TypeExpression(number);
        }

        public void EnterDecimalSeparator(string decSeparator)
        {
            var canBeEntered = Validator.ValidateDecimalSeparator(result);

            if (canBeEntered)
            {
                TypeExpression(decSeparator);
            }
        }

        public void EnterOperation(string operation)
        {
            var canBeEntered = Validator.ValidateOperator(result, expression, operation);

            if (canBeEntered)
            {
                TypeExpression(operation);
            }
        }

        public void EnterStartingBracket(string startingBracket)
        {
            Validator.ValidateStartingBracket(result);
            TypeExpression(startingBracket);
        }

        public void EnterEndingBracket(string endingBracket)
        {
            bool canBeEntered = Validator.ValidateEndingBracket(result);

            if (canBeEntered)
            {
                TypeExpression(endingBracket);
            }
        }

        //All of the clear methods
        public void Clear()
        {
            result.Clear();
            Validator.PreventEmptiness(result);
        }

        public void ClearEntry()
        {
            Clear();
            expression.Clear();
        }

        public void ClearLast()
        {
            result.Text = result.Text.Remove(result.TextLength - 1);
            Validator.PreventEmptiness(result);
        }

        //Methods connected with getting the current result
        public void DisplayResult()
        {
            Validator.ValidateGetResult(result);
            var currentExpression = result.Text + " =";

            if (TextRenderer.MeasureText(currentExpression, expression.Font).Width > expression.Width)
            {
                expression.TextAlign = HorizontalAlignment.Left;
            }
            else
            {
                expression.TextAlign = HorizontalAlignment.Right;
            }

            expression.Text = currentExpression;
            result.Text = GetCurrentResult().ToString();
        }

        public decimal GetCurrentResult()
        {
            Validator.ValidateGetResult(result);
            var currentResult = calculator.CalculateResult(result.Text);

            return currentResult;
        }

        public void EnterMemoryElement(decimal memoryElement)
        {
            Validator.ValidateMemoryRecalling(result, expression, memoryElement);
            TypeExpression(memoryElement.ToString());
        }

        //The method responsible for typing the expression. This method gets the current thing that the user wants to enter (number, operator, decimal separator etc.) and appends it to the result textbox
        private void TypeExpression(string text)
        {
            result.Text += text;
        }
    }
}
