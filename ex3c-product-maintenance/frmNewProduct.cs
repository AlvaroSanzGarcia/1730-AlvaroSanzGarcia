namespace ex3c_product_maintenance
{
    public partial class frmNewProduct : Form
    {
        private Product? product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbBook.Checked)
                {                  
                    if (txtCode.Text != "" && txtDescription.Text != ""
                        && txtPrice.Text != "" && txtAuthorOrVersion.Text != "")
                    {
                        if (Convert.ToDecimal(txtPrice.Text) > 0)
                        {
                            product = new Book(
                            txtCode.Text,
                            txtDescription.Text,
                            Convert.ToDecimal(txtPrice.Text),
                            txtAuthorOrVersion.Text);
                        }
                        else 
                        {
                            MessageBox.Show("'Price' must be greater than 0.");
                        }
                        
                    }
                    else 
                    {
                        MessageBox.Show("All fields are required.");                        
                    }
                    
                    
                }

                else
                {
                    product = new Software(
                        txtCode.Text,
                        txtDescription.Text,
                        Convert.ToDecimal(txtPrice.Text),
                        txtAuthorOrVersion.Text); ;
                }

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input String was not in the correct format. Pleas try again.");
            }
            
            
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                lblAuthorOrVersion.Text = "Author";
            }
            else
            {
                lblAuthorOrVersion.Text = "Version";
            }
        }
    }
}
