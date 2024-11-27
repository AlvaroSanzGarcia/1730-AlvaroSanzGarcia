namespace ex3c_product_maintenance
{
    public partial class frmMain : Form
    {
        
        private List<Product> products = new();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct frmNewProduct = new();
            Product newProduct = frmNewProduct.GetNewProduct();

            if (newProduct != null)
            {
                products.Add(newProduct);
                FillProductListBox();
            }
        }

        private void FillProductListBox()
        {
            lstbxProducts.Items.Clear();

            foreach (Product p in products)
            {
                lstbxProducts.Items.Add(p);
            }
        }
    }
}
