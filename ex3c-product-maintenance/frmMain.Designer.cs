namespace ex3c_product_maintenance
{
    partial class frmMain
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
            lstbxProducts = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstbxProducts
            // 
            lstbxProducts.FormattingEnabled = true;
            lstbxProducts.ItemHeight = 25;
            lstbxProducts.Location = new Point(24, 22);
            lstbxProducts.Name = "lstbxProducts";
            lstbxProducts.Size = new Size(486, 279);
            lstbxProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(536, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 41);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(536, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 41);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(536, 260);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(747, 328);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstbxProducts);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstbxProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
    }
}