using System.Security.Cryptography.X509Certificates;

namespace ex1c_food_truck
{
    public partial class FormFoodTruck : Form
    {
        public FormFoodTruck()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            textBoxHotDogs.Text = "0";
            textBoxHamburgers.Text = "0";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            Cart.ResetCart();


            Product hotDog = new Product();
            try
            {
                hotDog.Amount = Convert.ToInt32(textBoxHotDogs.Text);
                hotDog.Price = 4.00m;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount.", "Entry Error");
                textBoxHotDogs.Focus();
            }

            

            Product hamburger = new Product();
            try
            {
                hamburger.Amount = Convert.ToInt32(textBoxHamburgers.Text);
                hamburger.Price = 5.00m;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount.", "Entry Error");
                textBoxHamburgers.Focus();
            }

          

            //Result display
            textBoxHotDogTotal.Text = Cart.GetProductTotal(hotDog.Amount, hotDog.Price).ToString("c");
            textBoxHamburgerTotal.Text = Cart.GetProductTotal(hamburger.Amount, hamburger.Price).ToString("c");
            textBoxPretaxTotal.Text = Cart.GetPretaxTotal().ToString("c");
            textBoxTaxTotal.Text = Cart.GetTaxTotal().ToString("c");
            textBoxTotal.Text = Cart.GetTotalAfterTax().ToString("c");
            



            //// Variable declaration
            //decimal hotDogAmount = Convert.ToDecimal(textBoxHotDogs.Text);
            //decimal hamburgerAmount = Convert.ToDecimal(textBoxHamburgers.Text);
            //decimal hotDogPrice = 4;
            //decimal hamburgerPrice = 5;
            //decimal hotDogTotal = hotDogAmount * hotDogPrice;
            //decimal hamburgerTotal = hamburgerAmount * hamburgerPrice;
            //decimal pretaxTotal = hotDogTotal + hamburgerTotal;
            //decimal tax = 0.0687m;
            //decimal taxTotal = pretaxTotal * tax;

            //// Final total calculation
            //decimal total = pretaxTotal - taxTotal;

            //// Result display
            //textBoxHotDogTotal.Text = hotDogTotal.ToString();
            //textBoxHamburgerTotal.Text = hamburgerTotal.ToString();
            //textBoxPretaxTotal.Text = pretaxTotal.ToString();
            //textBoxTaxTotal.Text = taxTotal.ToString();
            //textBoxTotal.Text = total.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Textbox clearing
            textBoxHotDogs.Text = "0";
            textBoxHamburgers.Text = "0";
            textBoxHotDogTotal.Text = "";
            textBoxHamburgerTotal.Text = "";
            textBoxPretaxTotal.Text = "";
            textBoxTaxTotal.Text = "";
            textBoxTotal.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit the app
            Application.Exit();
        }
    }
}
