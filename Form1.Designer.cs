namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateButton = new Button();
            title = new Label();
            value1Label = new Label();
            value2Label = new Label();
            value1textBox = new TextBox();
            value2TextBox = new TextBox();
            radioButtonAddition = new RadioButton();
            radioButtonDiv = new RadioButton();
            radioButtonMul = new RadioButton();
            radioButtonSub = new RadioButton();
            answerTextBox = new TextBox();
            answerLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(227, 237);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(106, 23);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "CALCULATE";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(240, 52);
            title.Name = "title";
            title.Size = new Size(79, 15);
            title.TabIndex = 1;
            title.Text = "CALCULATOR";
            title.Click += label1_Click;
            // 
            // value1Label
            // 
            value1Label.AutoSize = true;
            value1Label.Location = new Point(187, 101);
            value1Label.Name = "value1Label";
            value1Label.Size = new Size(50, 15);
            value1Label.TabIndex = 2;
            value1Label.Text = "VALUE 1";
            value1Label.Click += label1_Click_1;
            // 
            // value2Label
            // 
            value2Label.AutoSize = true;
            value2Label.Location = new Point(187, 139);
            value2Label.Name = "value2Label";
            value2Label.Size = new Size(50, 15);
            value2Label.TabIndex = 3;
            value2Label.Text = "VALUE 2";
            // 
            // value1textBox
            // 
            value1textBox.Location = new Point(308, 102);
            value1textBox.Name = "value1textBox";
            value1textBox.Size = new Size(100, 23);
            value1textBox.TabIndex = 4;
            // 
            // value2TextBox
            // 
            value2TextBox.Location = new Point(308, 131);
            value2TextBox.Name = "value2TextBox";
            value2TextBox.Size = new Size(100, 23);
            value2TextBox.TabIndex = 5;
            // 
            // radioButtonAddition
            // 
            radioButtonAddition.AutoSize = true;
            radioButtonAddition.Location = new Point(98, 181);
            radioButtonAddition.Name = "radioButtonAddition";
            radioButtonAddition.Size = new Size(49, 19);
            radioButtonAddition.TabIndex = 6;
            radioButtonAddition.TabStop = true;
            radioButtonAddition.Text = "ADD";
            radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiv
            // 
            radioButtonDiv.AutoSize = true;
            radioButtonDiv.Location = new Point(407, 181);
            radioButtonDiv.Name = "radioButtonDiv";
            radioButtonDiv.Size = new Size(43, 19);
            radioButtonDiv.TabIndex = 7;
            radioButtonDiv.TabStop = true;
            radioButtonDiv.Text = "DIV";
            radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // radioButtonMul
            // 
            radioButtonMul.AutoSize = true;
            radioButtonMul.Location = new Point(307, 181);
            radioButtonMul.Name = "radioButtonMul";
            radioButtonMul.Size = new Size(50, 19);
            radioButtonMul.TabIndex = 8;
            radioButtonMul.TabStop = true;
            radioButtonMul.Text = "MUL";
            radioButtonMul.UseVisualStyleBackColor = true;
            radioButtonMul.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButtonSub
            // 
            radioButtonSub.AutoSize = true;
            radioButtonSub.Location = new Point(207, 181);
            radioButtonSub.Name = "radioButtonSub";
            radioButtonSub.Size = new Size(46, 19);
            radioButtonSub.TabIndex = 9;
            radioButtonSub.TabStop = true;
            radioButtonSub.Text = "SUB";
            radioButtonSub.UseVisualStyleBackColor = true;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(308, 208);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(100, 23);
            answerTextBox.TabIndex = 10;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(187, 216);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(54, 15);
            answerLabel.TabIndex = 11;
            answerLabel.Text = "ANSWER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answerLabel);
            Controls.Add(answerTextBox);
            Controls.Add(radioButtonSub);
            Controls.Add(radioButtonMul);
            Controls.Add(radioButtonDiv);
            Controls.Add(radioButtonAddition);
            Controls.Add(value2TextBox);
            Controls.Add(value1textBox);
            Controls.Add(value2Label);
            Controls.Add(value1Label);
            Controls.Add(title);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Label title;
        private Label value1Label;
        private Label value2Label;
        private TextBox value1textBox;
        private TextBox value2TextBox;
        private RadioButton radioButtonAddition;
        private RadioButton radioButtonDiv;
        private RadioButton radioButtonMul;
        private RadioButton radioButtonSub;
        private TextBox answerTextBox;
        private Label answerLabel;
    }
}
