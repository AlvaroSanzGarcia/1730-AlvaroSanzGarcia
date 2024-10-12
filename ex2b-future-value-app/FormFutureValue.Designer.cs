namespace ex2b_future_value_app
{
    partial class FormFutureValue
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonthlyInvestment = new TextBox();
            txtInterestRate = new TextBox();
            txtYears = new TextBox();
            txtFutureValue = new TextBox();
            btnExit = new Button();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 51);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 6;
            label1.Text = "Monthly Investement:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 104);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 7;
            label2.Text = "Yearly Interest Rate:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 152);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 8;
            label3.Text = "Number of Years:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 201);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 9;
            label4.Text = "Future Value:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(286, 45);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(216, 31);
            txtMonthlyInvestment.TabIndex = 0;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(286, 98);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(216, 31);
            txtInterestRate.TabIndex = 1;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(286, 149);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(216, 31);
            txtYears.TabIndex = 2;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(286, 198);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(216, 31);
            txtFutureValue.TabIndex = 3;
            txtFutureValue.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(354, 266);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(148, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(186, 266);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(148, 30);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // FormFutureValue
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(557, 331);
            Controls.Add(btnCalculate);
            Controls.Add(btnExit);
            Controls.Add(txtFutureValue);
            Controls.Add(txtYears);
            Controls.Add(txtInterestRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFutureValue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Value";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonthlyInvestment;
        private TextBox txtInterestRate;
        private TextBox txtYears;
        private TextBox txtFutureValue;
        private Button btnExit;
        private Button btnCalculate;
    }
}
