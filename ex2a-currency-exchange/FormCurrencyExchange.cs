namespace ex2a_currency_exchange
{
    public partial class FormCurrencyExchange : Form
    {
        public FormCurrencyExchange()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtAmountKyrgyzstan.Text = "0.00";
            txtAmountBrazil.Text = "0.00";
            txtAmountUruguay.Text = "0.00";
            txtAmountMorocco.Text = "0.00";

            txtRateKyrgyzstan.Text = "0.01185363";
            txtRateBrazil.Text = "0.18307601";
            txtRateUruguay.Text = "0.024296019";
            txtRateMorocco.Text = "0.10262374";

            txtUSDKyrgyzstan.Text = "0.00";
            txtUSDBrazil.Text = "0.00";
            txtUSDUruguay.Text = "0.00";
            txtUSDMorocco.Text = "0.00";

            txtTotalUSD.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void kyrgyzstanTextChanged(object sender, EventArgs e)
        {
            txtUSDKyrgyzstan.Text = (Convert.ToDecimal(txtAmountKyrgyzstan.Text) *
                    Convert.ToDecimal(txtRateKyrgyzstan.Text)).ToString("0.00");
        }

        private void brazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (Convert.ToDecimal(txtAmountBrazil.Text) *
                    Convert.ToDecimal(txtRateBrazil.Text)).ToString("0.00");
        }

        private void uruguayTextChanged(object sender, EventArgs e)
        {
            txtUSDUruguay.Text = (Convert.ToDecimal(txtAmountUruguay.Text) *
                    Convert.ToDecimal(txtRateUruguay.Text)).ToString("0.00");
        }

        private void moroccoTextChanged(object sender, EventArgs e)
        {
            txtUSDMorocco.Text = (Convert.ToDecimal(txtAmountMorocco.Text) *
                    Convert.ToDecimal(txtRateMorocco.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDKyrgyzstan.Text) +
                Convert.ToDecimal(txtUSDBrazil.Text) +
                Convert.ToDecimal(txtUSDUruguay.Text) +
                Convert.ToDecimal(txtUSDMorocco.Text)
                ).ToString();
        }
    }
}
