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
            if (rbBook.Checked)
            {
                product = new Book(
                    txtCode.Text, 
                    txtDescription.Text, 
                    Convert.ToDecimal(txtPrice.Text), 
                    txtAuthorOrVersion.Text);
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
    }
}
