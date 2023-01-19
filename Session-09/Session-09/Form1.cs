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
            Multiplication
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
                    result = value1 + value2;
                    
                    break;

                default:
                    break;
                case CalcOperation.Multiplication:
                    result = value1 * value2;

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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " * ";
            _calcOperation = CalcOperation.Multiplication;
        }
    }
}