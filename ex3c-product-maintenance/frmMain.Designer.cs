namespace ex3c_product_maintenance
{
    partial class frmMain
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(605, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 42);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(605, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(605, 260);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 42);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(22, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(554, 279);
            listBox1.TabIndex = 4;
            // 
            // frmMain
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(785, 323);
            Controls.Add(listBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
        private ListBox listBox1;
    }
}
