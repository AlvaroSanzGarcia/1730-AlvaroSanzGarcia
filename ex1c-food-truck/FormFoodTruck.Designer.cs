namespace ex1c_food_truck
{
    partial class FormFoodTruck
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
            textBoxHotDogs = new TextBox();
            textBoxHamburgers = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonCalculate = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            textBoxHotDogTotal = new TextBox();
            textBoxHamburgerTotal = new TextBox();
            textBoxPretaxTotal = new TextBox();
            textBoxTaxTotal = new TextBox();
            textBoxTotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 50);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Hot Dogs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 91);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Hamburgers:";
            // 
            // textBoxHotDogs
            // 
            textBoxHotDogs.Location = new Point(203, 47);
            textBoxHotDogs.Name = "textBoxHotDogs";
            textBoxHotDogs.Size = new Size(49, 31);
            textBoxHotDogs.TabIndex = 0;
            // 
            // textBoxHamburgers
            // 
            textBoxHamburgers.Location = new Point(203, 87);
            textBoxHamburgers.Name = "textBoxHamburgers";
            textBoxHamburgers.Size = new Size(49, 31);
            textBoxHamburgers.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 44);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 4;
            label3.Text = "x $4.00 =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 90);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 5;
            label4.Text = "x $5.00 =";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(55, 386);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(222, 386);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 34);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(387, 386);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(112, 34);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxHotDogTotal
            // 
            textBoxHotDogTotal.Location = new Point(400, 38);
            textBoxHotDogTotal.Name = "textBoxHotDogTotal";
            textBoxHotDogTotal.ReadOnly = true;
            textBoxHotDogTotal.Size = new Size(150, 31);
            textBoxHotDogTotal.TabIndex = 9;
            textBoxHotDogTotal.TabStop = false;
            // 
            // textBoxHamburgerTotal
            // 
            textBoxHamburgerTotal.Location = new Point(400, 88);
            textBoxHamburgerTotal.Name = "textBoxHamburgerTotal";
            textBoxHamburgerTotal.ReadOnly = true;
            textBoxHamburgerTotal.Size = new Size(150, 31);
            textBoxHamburgerTotal.TabIndex = 10;
            textBoxHamburgerTotal.TabStop = false;
            // 
            // textBoxPretaxTotal
            // 
            textBoxPretaxTotal.Location = new Point(400, 142);
            textBoxPretaxTotal.Name = "textBoxPretaxTotal";
            textBoxPretaxTotal.ReadOnly = true;
            textBoxPretaxTotal.Size = new Size(150, 31);
            textBoxPretaxTotal.TabIndex = 11;
            textBoxPretaxTotal.TabStop = false;
            // 
            // textBoxTaxTotal
            // 
            textBoxTaxTotal.Location = new Point(400, 196);
            textBoxTaxTotal.Name = "textBoxTaxTotal";
            textBoxTaxTotal.ReadOnly = true;
            textBoxTaxTotal.Size = new Size(150, 31);
            textBoxTaxTotal.TabIndex = 12;
            textBoxTaxTotal.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(400, 254);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(150, 31);
            textBoxTotal.TabIndex = 13;
            textBoxTotal.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 148);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 14;
            label5.Text = "Pretax total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 202);
            label6.Name = "label6";
            label6.Size = new Size(40, 25);
            label6.TabIndex = 15;
            label6.Text = "Tax:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 260);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 16;
            label7.Text = "Total:";
            // 
            // FormFoodTruck
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(593, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxTaxTotal);
            Controls.Add(textBoxPretaxTotal);
            Controls.Add(textBoxHamburgerTotal);
            Controls.Add(textBoxHotDogTotal);
            Controls.Add(buttonExit);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxHamburgers);
            Controls.Add(textBoxHotDogs);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFoodTruck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Food Truck";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxHotDogs;
        private TextBox textBoxHamburgers;
        private Label label3;
        private Label label4;
        private Button buttonCalculate;
        private Button buttonClear;
        private Button buttonExit;
        private TextBox textBoxHotDogTotal;
        private TextBox textBoxHamburgerTotal;
        private TextBox textBoxPretaxTotal;
        private TextBox textBoxTaxTotal;
        private TextBox textBoxTotal;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
