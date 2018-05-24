namespace SimpleCalculator.Core.Controllers
{
    using SimpleCalculator.Core.Controllers.Contracts;
    using System;
    using System.Windows.Forms;

    public class HistoryController : IHistoryController
    {
        private RichTextBox history;

        public HistoryController(RichTextBox history)
        {
            this.history = history;
        }
        
        public void Store(string expression, string result)
        {
            string equation = String.Format("{0}{1}{2}{3}",
                expression,
                Environment.NewLine,
                result,
                Environment.NewLine);

            history.SelectionAlignment = HorizontalAlignment.Right;
            history.Text = history.Text.Insert(0, equation);
        }

        public void Clear()
        {
            this.history.Clear();
        }
    }
}
