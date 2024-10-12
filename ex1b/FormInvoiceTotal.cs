using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1b
{
    public partial class FormInvoiceTotal : Form
    {
        public FormInvoiceTotal()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Variable declaration 
            decimal subtotal = Convert.ToDecimal(textBoxSubtotal.Text);
            decimal discountPercent = 0m;

            // If-else statment for discountPercent
            if (subtotal >= 500) {
                discountPercent = 0.20m;
            }
            else if (subtotal >= 250 && subtotal < 500) {
                discountPercent = 0.15m;
            }
            else if (subtotal >= 100 && subtotal < 250) {
                discountPercent = 0.10m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal total = subtotal - discountAmount;


            // Display of results
            textBoxDiscountPercent.Text = discountPercent.ToString();
            textBoxDiscountAmount.Text = discountAmount.ToString();
            textBoxTotal.Text = total.ToString();
        }    
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInvoiceTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
