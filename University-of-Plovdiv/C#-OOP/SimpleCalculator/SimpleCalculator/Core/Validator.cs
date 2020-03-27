using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator.Core
{
    //The class responsible for all the validation needed when the user types the expression
    public static class Validator
    {
        private const string defaultResultValue = "0";
        private const string startingBracket = "(";
        private const string endingBracket = ")";
        private const string decimalSeparator = ".";
        private const string multiplication = "x";
        private const string addition = "+";
        private const string substraction = "-";

        private static bool operatorPressed = false;
        private static bool numberPressed = true;
        private static bool decSeparatorPressed = false;
        private static bool isExpressionCalculated = false;

        private static int countStartingBrackets = 0;
        private static int countEndingBrackets = 0;

        //All of the methods for validating the user input
        public static void ValidateNumber(TextBox result, TextBox expression)
        {
            if (result.Text == defaultResultValue || isExpressionCalculated)
            {
                expression.Clear();
                result.Clear();
                isExpressionCalculated = false;
            }

            if (result.Text.EndsWith(endingBracket))
            {
                result.Text += multiplication;
            }

            operatorPressed = false;
            numberPressed = true;
        }

        public static bool ValidateOperator(TextBox result, TextBox expression, string operation)
        {
            if (expression.Text == string.Empty || isExpressionCalculated)
            {
                expression.Clear();
                isExpressionCalculated = false;
            }

            if (operatorPressed || result.Text.EndsWith(decimalSeparator))
            {
                result.Text = result.Text.Remove(result.TextLength - 1);
            }

            if (!result.Text.EndsWith(startingBracket))
            {
                if (operation == substraction && result.Text == defaultResultValue)
                {
                    result.Clear();
                }

                operatorPressed = true;
                decSeparatorPressed = false;
                numberPressed = false;
                return true;
            }

            return false;
        }

        public static bool ValidateDecimalSeparator(TextBox result)
        {
            if (operatorPressed || !decSeparatorPressed || (isExpressionCalculated && !result.Text.Contains('.')))
            {
                if (operatorPressed || result.Text.EndsWith(startingBracket))
                {
                    result.Text += defaultResultValue;
                    operatorPressed = false;
                }

                decSeparatorPressed = true;
                numberPressed = true;
                isExpressionCalculated = false;

                return true;
            }

            return false;
        }

        public static void ValidateStartingBracket(TextBox result)
        {
            countStartingBrackets++;

            if (numberPressed)
            {
                if (result.Text == defaultResultValue || isExpressionCalculated)
                {
                    result.Clear();
                    isExpressionCalculated = false;
                }
                else
                {
                    result.Text += multiplication;
                }
            }

            operatorPressed = false;
            numberPressed = false;
        }

        public static bool ValidateEndingBracket(TextBox result)
        {
            if (countEndingBrackets + 1 <= countStartingBrackets && !operatorPressed && !result.Text.EndsWith("("))
            {
                operatorPressed = false;
                countEndingBrackets++;

                return true;
            }

            return false;
        }

        public static void PreventEmptiness(TextBox result)
        {
            if (result.Text == string.Empty)
            {
                result.Text = defaultResultValue;
            }
        }

        public static void ValidateGetResult(TextBox result)
        {
            string transformedResult = result.Text;
            TrimOperator(ref transformedResult);
            AddMissingEndingBrackets(ref transformedResult);
            result.Text = transformedResult;

            isExpressionCalculated = true;

            countStartingBrackets = 0;
            countEndingBrackets = 0;
        }

        //Methods for memory validation
        public static bool ValidateIsMemoryEmpty(ListBox memory)
        {
            if (memory.Items.Count == 0)
            {
                return true;
            }

            return false;
        }

        public static void ValidateMemoryRecalling(TextBox result, TextBox expression, decimal memory)
        {
            if (!operatorPressed)
            {
                if (isExpressionCalculated)
                {
                    expression.Clear();
                }

                if (result.Text == defaultResultValue)
                {
                    result.Clear();
                    numberPressed = false;
                }

                if (numberPressed)
                {
                    result.Text += multiplication;
                }
            }
            else if (result.Text.EndsWith(addition) && memory < 0)
            {
                result.Text = result.Text.Remove(result.TextLength - 1);
            }

            numberPressed = true;
            operatorPressed = false;
        }

        //Private methods for deleting or adding some of the symbols the user may have missed to add or deleting the ones that are not not necessary
        private static void TrimOperator(ref string result)
        {
            var lastSymbol = result[result.Length - 1];
            if (!Char.IsDigit(lastSymbol) && lastSymbol != Char.Parse(startingBracket) && lastSymbol != Char.Parse(endingBracket))
            {
                result = result.Remove(result.Length - 1);
            }
        }

        private static void AddMissingEndingBrackets(ref string result)
        {
            if (countStartingBrackets > countEndingBrackets)
            {
                var difference = countStartingBrackets - countEndingBrackets;
                for (int i = 0; i < difference; i++)
                {
                    result += ")";
                }
            }
        }
    }
}
