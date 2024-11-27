namespace ex3c_product_maintenance
{
    partial class frmNewProduct
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
            label2 = new Label();
            label3 = new Label();
            lblAuthorOrVersion = new Label();
            txtCode = new TextBox();
            txtAuthorOrVersion = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            rbBook = new RadioButton();
            rbSoftware = new RadioButton();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(100, 84);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 133);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(105, 181);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // lblAuthorOrVersion
            // 
            lblAuthorOrVersion.AutoSize = true;
            lblAuthorOrVersion.Font = new Font("Segoe UI", 12F);
            lblAuthorOrVersion.Location = new Point(83, 230);
            lblAuthorOrVersion.Name = "lblAuthorOrVersion";
            lblAuthorOrVersion.Size = new Size(87, 32);
            lblAuthorOrVersion.TabIndex = 3;
            lblAuthorOrVersion.Text = "Author";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(183, 81);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(314, 39);
            txtCode.TabIndex = 4;
            // 
            // txtAuthorOrVersion
            // 
            txtAuthorOrVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthorOrVersion.Location = new Point(183, 227);
            txtAuthorOrVersion.Name = "txtAuthorOrVersion";
            txtAuthorOrVersion.Size = new Size(314, 39);
            txtAuthorOrVersion.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(183, 178);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(314, 39);
            txtPrice.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(183, 130);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(314, 39);
            txtDescription.TabIndex = 7;
            // 
            // rbBook
            // 
            rbBook.AutoSize = true;
            rbBook.Font = new Font("Segoe UI", 12F);
            rbBook.Location = new Point(105, 33);
            rbBook.Name = "rbBook";
            rbBook.Size = new Size(93, 36);
            rbBook.TabIndex = 8;
            rbBook.TabStop = true;
            rbBook.Text = "Book";
            rbBook.UseVisualStyleBackColor = true;
            // 
            // rbSoftware
            // 
            rbSoftware.AutoSize = true;
            rbSoftware.Font = new Font("Segoe UI", 12F);
            rbSoftware.Location = new Point(218, 33);
            rbSoftware.Name = "rbSoftware";
            rbSoftware.Size = new Size(132, 36);
            rbSoftware.TabIndex = 9;
            rbSoftware.TabStop = true;
            rbSoftware.Text = "Software";
            rbSoftware.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(183, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(346, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmNewProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(546, 355);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(rbSoftware);
            Controls.Add(rbBook);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtAuthorOrVersion);
            Controls.Add(txtCode);
            Controls.Add(lblAuthorOrVersion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNewProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblAuthorOrVersion;
        private TextBox txtCode;
        private TextBox txtAuthorOrVersion;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private RadioButton rbBook;
        private RadioButton rbSoftware;
        private Button btnCancel;
        private Button btnSave;
    }
}