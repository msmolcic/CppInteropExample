namespace CppInvoker
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayCalculatedResult(int result) => lblCalculatedResult.Text = result.ToString();

        private (int first, int second) GetInputValues() => (first: (int)numFirst.Value, second: (int)numSecond.Value);

        private void BtnSum_Click(object sender, EventArgs e)
        {
            var (first, second) = GetInputValues();
            var result = Calculator.Add(first, second);
            DisplayCalculatedResult(result);
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            var (first, second) = GetInputValues();
            var result = Calculator.Subtract(first, second);
            DisplayCalculatedResult(result);
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            var (first, second) = GetInputValues();
            var result = Calculator.Multiply(first, second);
            DisplayCalculatedResult(result);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            var (first, second) = GetInputValues();

            if (second == 0)
            {
                errValidator.SetError(numSecond, "Division by zero.");
                return;
            }

            var result = Calculator.Divide(first, second);
            DisplayCalculatedResult(result);
        }

        private void NumSecond_ValueChanged(object sender, EventArgs e) => errValidator.Clear();
    }
}
