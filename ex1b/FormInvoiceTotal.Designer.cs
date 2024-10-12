namespace ex1b
{
    partial class FormInvoiceTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxSubtotal = new TextBox();
            label2 = new Label();
            textBoxDiscountPercent = new TextBox();
            textBoxTotal = new TextBox();
            label3 = new Label();
            textBoxDiscountAmount = new TextBox();
            label4 = new Label();
            buttonCalculate = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(128, 52);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(265, 52);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(172, 31);
            textBoxSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 111);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 2;
            label2.Text = "Discount Percent:";
            // 
            // textBoxDiscountPercent
            // 
            textBoxDiscountPercent.Location = new Point(265, 111);
            textBoxDiscountPercent.Name = "textBoxDiscountPercent";
            textBoxDiscountPercent.ReadOnly = true;
            textBoxDiscountPercent.Size = new Size(172, 31);
            textBoxDiscountPercent.TabIndex = 3;
            textBoxDiscountPercent.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(265, 236);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(172, 31);
            textBoxTotal.TabIndex = 7;
            textBoxTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(166, 236);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 6;
            label3.Text = "Total:";
            // 
            // textBoxDiscountAmount
            // 
            textBoxDiscountAmount.Location = new Point(265, 177);
            textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            textBoxDiscountAmount.ReadOnly = true;
            textBoxDiscountAmount.Size = new Size(172, 31);
            textBoxDiscountAmount.TabIndex = 5;
            textBoxDiscountAmount.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 180);
            label4.Name = "label4";
            label4.Size = new Size(206, 32);
            label4.TabIndex = 4;
            label4.Text = "Discount Amount:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 12F);
            buttonCalculate.Location = new Point(176, 313);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(123, 44);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "&Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(314, 313);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(123, 44);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormInvoiceTotal
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(481, 401);
            Controls.Add(buttonExit);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxTotal);
            Controls.Add(label3);
            Controls.Add(textBoxDiscountAmount);
            Controls.Add(label4);
            Controls.Add(textBoxDiscountPercent);
            Controls.Add(label2);
            Controls.Add(textBoxSubtotal);
            Controls.Add(label1);
            Name = "FormInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += FormInvoiceTotal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSubtotal;
        private Label label2;
        private TextBox textBoxDiscountPercent;
        private TextBox textBoxTotal;
        private Label label3;
        private TextBox textBoxDiscountAmount;
        private Label label4;
        private Button buttonCalculate;
        private Button buttonExit;
    }
}