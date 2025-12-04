namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!double.TryParse(value1textBox.Text, out double value1))
            {
                MessageBox.Show("Please enter a valid number for Value 1", "Input Error");
                return;
            }

            if (!double.TryParse(value2TextBox.Text, out double value2))
            {
                MessageBox.Show("Please enter a valid number for Value 2", "Input Error");
                return;
            }

            // Determine which operation is selected
            double result = 0;
            bool operationSelected = false;

            if (radioButtonAddition.Checked)
            {
                result = value1 + value2;
                operationSelected = true;
            }
            else if (radioButtonSub.Checked)
            {
                result = value1 - value2;
                operationSelected = true;
            }
            else if (radioButtonMul.Checked)
            {
                result = value1 * value2;
                operationSelected = true;
            }
            else if (radioButtonDiv.Checked)
            {
                if (value2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero", "Math Error");
                    return;
                }
                result = value1 / value2;
                operationSelected = true;
            }

            if (!operationSelected)
            {
                MessageBox.Show("Please select an operation", "Selection Error");
                return;
            }

            // Display the result
            answerTextBox.Text = result.ToString();
        }

 
    }
}