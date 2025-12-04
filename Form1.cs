using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Panel displayPanel;
        private Label resultLabel;
        private Label operationLabel;
        private TableLayoutPanel buttonPanel;
        private string currentOperation = "";
        private double firstValue = 0;
        private bool operationPending = false;
        private bool shouldClearDisplay = false;

        public Form1()
        {
            InitializeModernUI();
        }

        private void InitializeModernUI()
        {
            // Form setup
            this.Text = "Calculator";
            this.Size = new Size(350, 500);
            this.BackColor = Color.FromArgb(32, 32, 32);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display panel
            displayPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                BackColor = Color.FromArgb(45, 45, 45),
                Padding = new Padding(20)
            };

            operationLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 30,
                Text = "",
                ForeColor = Color.FromArgb(150, 150, 150),
                Font = new Font("Segoe UI", 12F),
                TextAlign = ContentAlignment.MiddleRight
            };

            resultLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "0",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight
            };

            displayPanel.Controls.Add(resultLabel);
            displayPanel.Controls.Add(operationLabel);

            // Button panel
            buttonPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 5,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(32, 32, 32)
            };

            // Setup grid
            for (int i = 0; i < 4; i++)
                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int i = 0; i < 5; i++)
                buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            // Button definitions
            string[,] buttons = new string[,]
            {
                { "C", "⌫", "%", "÷" },
                { "7", "8", "9", "×" },
                { "4", "5", "6", "-" },
                { "1", "2", "3", "+" },
                { "±", "0", ".", "=" }
            };

            // Create buttons
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    string btnText = buttons[row, col];
                    Button btn = CreateButton(btnText);
                    buttonPanel.Controls.Add(btn, col, row);
                }
            }

            this.Controls.Add(buttonPanel);
            this.Controls.Add(displayPanel);
        }

        private Button CreateButton(string text)
        {
            Button btn = new Button
            {
                Text = text,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Margin = new Padding(5),
                Cursor = Cursors.Hand
            };

            // Color scheme
            bool isOperator = "÷×-+=".Contains(text);
            bool isSpecial = "C⌫%±".Contains(text);

            if (isOperator)
            {
                btn.BackColor = Color.FromArgb(255, 159, 10);
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }
            else if (isSpecial)
            {
                btn.BackColor = Color.FromArgb(80, 80, 80);
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btn.BackColor = Color.FromArgb(60, 60, 60);
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }

            // Hover effects
            btn.FlatAppearance.MouseOverBackColor = isOperator
                ? Color.FromArgb(255, 179, 50)
                : Color.FromArgb(80, 80, 80);

            btn.Click += Button_Click;
            return btn;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnText = btn.Text;

            // Number buttons
            if (double.TryParse(btnText, out _) || btnText == ".")
            {
                if (shouldClearDisplay || resultLabel.Text == "0")
                {
                    resultLabel.Text = btnText == "." ? "0." : btnText;
                    shouldClearDisplay = false;
                }
                else
                {
                    if (btnText == "." && resultLabel.Text.Contains("."))
                        return;
                    resultLabel.Text += btnText;
                }
            }
            // Clear
            else if (btnText == "C")
            {
                resultLabel.Text = "0";
                operationLabel.Text = "";
                currentOperation = "";
                firstValue = 0;
                operationPending = false;
            }
            // Backspace
            else if (btnText == "⌫")
            {
                if (resultLabel.Text.Length > 1)
                    resultLabel.Text = resultLabel.Text.Substring(0, resultLabel.Text.Length - 1);
                else
                    resultLabel.Text = "0";
            }
            // Plus/Minus
            else if (btnText == "±")
            {
                if (double.TryParse(resultLabel.Text, out double val))
                    resultLabel.Text = (-val).ToString();
            }
            // Percentage
            else if (btnText == "%")
            {
                if (double.TryParse(resultLabel.Text, out double val))
                    resultLabel.Text = (val / 100).ToString();
            }
            // Operations
            else if ("÷×-+".Contains(btnText))
            {
                if (operationPending)
                    Calculate();

                if (double.TryParse(resultLabel.Text, out firstValue))
                {
                    currentOperation = btnText;
                    operationLabel.Text = $"{firstValue} {btnText}";
                    operationPending = true;
                    shouldClearDisplay = true;
                }
            }
            // Equals
            else if (btnText == "=")
            {
                Calculate();
            }
        }

        private void Calculate()
        {
            if (!operationPending || !double.TryParse(resultLabel.Text, out double secondValue))
                return;

            double result = 0;
            bool validOperation = true;

            switch (currentOperation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "×":
                    result = firstValue * secondValue;
                    break;
                case "÷":
                    if (secondValue == 0)
                    {
                        resultLabel.Text = "Error";
                        validOperation = false;
                    }
                    else
                        result = firstValue / secondValue;
                    break;
            }

            if (validOperation)
            {
                resultLabel.Text = result.ToString("G");
                operationLabel.Text = $"{firstValue} {currentOperation} {secondValue} =";
            }

            operationPending = false;
            shouldClearDisplay = true;
        }

        // Keep old event handlers for compatibility with designer
        private void button1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
    }
}