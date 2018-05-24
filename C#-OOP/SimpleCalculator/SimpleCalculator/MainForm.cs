//Simple Calculator made by Alexander Yonchev
namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using SimpleCalculator.Core.Controllers;
    using SimpleCalculator.Core.Controllers.Contracts;
    using SimpleCalculator.Entities;

    //That is the class which handles all events and calls the needed controller to execute the command. It's much like an engine class.
    public partial class MainForm : Form
    {
        private IExpressionController expressionController;
        private IMemoryController memoryController;
        private IHistoryController historyController;
        
        public MainForm()
        {
            InitializeComponent();
            this.historyController = new HistoryController(history);
            this.memoryController = new MemoryController(memory);
            this.expressionController = new ExpressionController(new Calculator(), result, expression);
        }

        //Here are the events that are raised when the user enters something in the result textbox.
        private void EnterNumber(object sender, EventArgs e)
        {
            var currentNumberButton = (Button)sender;
            expressionController.EnterNumber(currentNumberButton.Text);
            ManipulateReadability();
        }

        private void EnterOperation(object sender, EventArgs e)
        {
            Button currentOperationButton = (Button)sender;
            expressionController.EnterOperation(currentOperationButton.Text);
            ManipulateReadability();
        }

        private void decSeparator_Click(object sender, EventArgs e)
        {
            var decSeparatorButton = (Button)sender;
            expressionController.EnterDecimalSeparator(decSeparatorButton.Text);

            ManipulateReadability();
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            expressionController.ClearEntry();
            ManipulateReadability();
        }

        private void Clear(object sender, EventArgs e)
        {
            expressionController.Clear();
            ManipulateReadability();
        }

        private void ClearLast(object sender, EventArgs e)
        {
            expressionController.ClearLast();
            ManipulateReadability();
        }

        private void startingBracket_Click(object sender, EventArgs e)
        {
            var startingBracket = (Button) sender;
            expressionController.EnterStartingBracket(startingBracket.Text);
            ManipulateReadability();
        }

        private void endingBracket_Click(object sender, EventArgs e)
        {
            var endingBracket = (Button) sender;
            expressionController.EnterEndingBracket(endingBracket.Text);
            ManipulateReadability();
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            try
            {
                expressionController.DisplayResult();
                historyController.Store(expression.Text, result.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
                expressionController.ClearEntry();
            }
        }

        //Event that clears the history
        private void historyClear_Click(object sender, EventArgs e)
        {
            historyController.Clear();
        }

        //Here are the events for the keyboard typing
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pressedKey = e.KeyChar.ToString().Replace("*", "x").Replace("/", "÷").Replace("c", "C");
            char pressedKeyChar = Char.Parse(pressedKey);

            char[] permittedSymbols = {'x', '÷', '-', '+', '(', ')', '=', 'C', '.' ,'%' };
            if (Char.IsDigit(pressedKeyChar) || permittedSymbols.Contains(pressedKeyChar))
            {
                var button = GetAll(this, typeof(Button)).Cast<Button>().FirstOrDefault(btn => btn.Text.Trim() == pressedKey.ToString());
                button.PerformClick();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                ClearLast(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                ClearEntry(sender, e);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = getResult;
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(historyClear, "Clear history.");
            TP.SetToolTip(memoryClear, "Memory clear.");
            TP.SetToolTip(memoryAddition, "Add to memory.");
            TP.SetToolTip(memorySubstraction, "Substract from memory.");
            TP.SetToolTip(memoryStore, "Store in memory.");
            TP.SetToolTip(memoryRecall, "Memory recall.");
        }

        //Here are all of the events connected with the memory
        private void memoryClear_Click(object sender, EventArgs e)
        {
            memoryController.ClearMemory();
        }

        private void memoryStore_Click(object sender, EventArgs e)
        {
            try
            {
                var currentResult = expressionController.GetCurrentResult();
                memoryController.MemoryStore(currentResult);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void memoryRecall_Click(object sender, EventArgs e)
        {
            try
            {
                var uppermostElement = memoryController.MemoryRecall;
                expressionController.EnterMemoryElement(uppermostElement);
            }
            catch (Exception exception)
            {
                MessageBox.Show("No memory!");
            }
        }

        private void memoryAddition_Click(object sender, EventArgs e)
        {
            var currentResult = expressionController.GetCurrentResult();
            memoryController.MemoryAddition(currentResult);
        }

        private void memorySubstraction_Click(object sender, EventArgs e)
        {
            var currentResult = expressionController.GetCurrentResult();
            memoryController.MemorySubstract(currentResult);
        }

        //With that method I get all of the controls in the form
        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        //With that method I guarantee that if the text in the result textbox gets wider than the textbox itself it will be visible to the user.I also guarantee that after every command the getResult button will be focused and if the user presses enter the getResult_Click event will be raised.
        private void ManipulateReadability()
        {
            this.result.Focus();
            this.getResult.Focus();
        }
    }
}
