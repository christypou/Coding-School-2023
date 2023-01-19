using CalculationLibrary;
using static CalculationLibrary.Substraction;

namespace Session_09
{
    public partial class Form1 : Form
    {
        public decimal? value1 = null;
        public decimal? value2 = null;
        public decimal? result = null;
        private CalcOperation _calcOperation;
        enum CalcOperation
        {
            Addition,
            Multiplication,
            Substraction,
            Division,
            Power
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " + ";
            _calcOperation = CalcOperation.Addition;

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            AssignNumber(3);
            ctrlDisplay.Text += 3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignNumber(1);
            ctrlDisplay.Text += 1;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AssignNumber(2);
            ctrlDisplay.Text += 2;
        }

        private void OperationSum_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:
                     Addition addition = new Addition();
                    result = addition.Do(value1, value2);
                    break;
                case CalcOperation.Substraction:
                    Substraction substraction = new Substraction();
                    result = substraction.Do(value1, value2);
                    break;


                case CalcOperation.Multiplication:
                    Multiplication multiplication = new Multiplication();
                    result = multiplication.Do(value1, value2);
                    break;
                case CalcOperation.Division:
                    Division division = new Division();
                    result = division.Do(value1, value2);

                    break;
                case CalcOperation.Power:
                    Power power = new Power();
                    result = power.Do(value1, value2);
                    break;
                

            }
            ctrlDisplay.Text += result;
        }

        public void AssignNumber(decimal? value)
        {
            if (result != null)
            {

                ctrlDisplay.Text = string.Empty;
                value1 = null;
                value2 = null;
                result = null;
            }
            
            if (value1 == null)
            {
                value1 = value;
            }
            else
            {
                value2 = value;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignNumber(4);
            ctrlDisplay.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignNumber(5);
            ctrlDisplay.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AssignNumber(6);
            ctrlDisplay.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AssignNumber(7);
            ctrlDisplay.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AssignNumber(8);
            ctrlDisplay.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AssignNumber(9);
            ctrlDisplay.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += (char)0x221A;
            result = (decimal?)Math.Sqrt((double)value1);
            
            ctrlDisplay.Text += " ="+ result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " * ";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " / ";
            _calcOperation = CalcOperation.Division;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AssignNumber(0);
            ctrlDisplay.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " ^ ";
            _calcOperation = CalcOperation.Power;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " - ";
            _calcOperation = CalcOperation.Substraction;
        }

        private void ctrlDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}