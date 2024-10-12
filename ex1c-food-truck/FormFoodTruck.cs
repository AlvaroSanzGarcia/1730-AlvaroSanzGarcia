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

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Variable declaration
            decimal hotDogAmount = Convert.ToDecimal(textBoxHotDogs.Text);
            decimal hamburgerAmount = Convert.ToDecimal(textBoxHamburgers.Text);
            decimal hotDogPrice = 4;
            decimal hamburgerPrice = 5;
            decimal hotDogTotal = hotDogAmount * hotDogPrice;
            decimal hamburgerTotal = hamburgerAmount * hamburgerPrice;
            decimal pretaxTotal = hotDogTotal + hamburgerTotal;
            decimal tax = 0.0687m;
            decimal taxTotal = pretaxTotal * tax;

            // Final total calculation
            decimal total = pretaxTotal - taxTotal;

            // Result display
            textBoxHotDogTotal.Text = hotDogTotal.ToString();
            textBoxHamburgerTotal.Text = hamburgerTotal.ToString();
            textBoxPretaxTotal.Text = pretaxTotal.ToString();
            textBoxTaxTotal.Text = taxTotal.ToString();
            textBoxTotal.Text = total.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Textbox clearing
            textBoxHotDogs.Text = "";
            textBoxHamburgers.Text = "";
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
