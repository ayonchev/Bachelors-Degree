namespace SimpleCalculator.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data;

    public class Calculator : ICalculator
    {
        private DataTable dt;

        public Calculator()
        {
            this.dt = new DataTable();
        }

        public decimal CalculateResult(string expression)
        {
            expression = TransformExpression(expression);

            var result = Convert.ToDecimal(dt.Compute(expression, ""));
            result = TrimTrailingZeros(result);

            return result;
        }

        private string TransformExpression(string currentExpression)
        {
            currentExpression = currentExpression.Replace("%", " / 100 *").Replace('x', '*').Replace('÷', '/');

            return currentExpression;
        }

        private static decimal TrimTrailingZeros(decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }
    }
}
