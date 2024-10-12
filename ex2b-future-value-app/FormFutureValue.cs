namespace ex2b_future_value_app
{
    public partial class FormFutureValue : Form
    {
        public FormFutureValue()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1.Input from user
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);
           
            // 2. Convert yearly values to monthly values
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            // 3. Calculate future value with a for loop
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                             * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
            
            
        }
    }
}
