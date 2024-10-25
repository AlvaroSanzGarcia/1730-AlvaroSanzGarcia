namespace ex2e_boolean_calculations
{
    public partial class Form1 : Form
    {
        private readonly string FAIL = "Fail";
        private readonly string SUCCESS = "Success";
        private readonly string ERROR = "Error";
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";

        }

        private void setFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = FAIL;
            textBox2ResultA.Text = FAIL;
            textBox3ResultA.Text = FAIL;
            textBox4ResultA.Text = FAIL;
            textBox5ResultA.Text = FAIL;
            textBox6ResultA.Text = FAIL;
            textBox7ResultA.Text = FAIL;
            textBox8ResultA.Text = FAIL;
            textBox9ResultA.Text = FAIL;
            textBox10ResultA.Text = FAIL;

            textBox1ResultB.Text = SUCCESS;
            textBox2ResultB.Text = SUCCESS;
            textBox3ResultB.Text = SUCCESS;
            textBox4ResultB.Text = SUCCESS;
            textBox5ResultB.Text = SUCCESS;
            textBox6ResultB.Text = SUCCESS;
            textBox7ResultB.Text = SUCCESS;
            textBox8ResultB.Text = SUCCESS;
            textBox9ResultB.Text = SUCCESS;
            textBox10ResultB.Text = SUCCESS;

            //test 1
            textBox1ResultA.Text = RelationalCalculations.IsFrank(textBox1Input.Text) ? SUCCESS : FAIL;
            textBox1ResultB.Text = RelationalCalculations.IsFrank(textBox1Input.Text) ? SUCCESS : FAIL;


            //test 2
            textBox2ResultA.Text = RelationalCalculations.IsEmpty(textBox2Input.Text) ? SUCCESS : FAIL;
            textBox2ResultB.Text = RelationalCalculations.IsEmpty(textBox2Input.Text) ? SUCCESS : FAIL;


            //test 3
            try
            {
                decimal val3 = Convert.ToDecimal(textBox3Input.Text);

                textBox3ResultA.Text = RelationalCalculations.IsTwoPointThree(val3) ? SUCCESS : FAIL;
                textBox3ResultB.Text = RelationalCalculations.IsTwoPointThree(val3) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox3ResultA.Text = ERROR;
                textBox3ResultB.Text = ERROR;
            }


            //test 4
            try
            {
                bool val4 = Convert.ToBoolean(textBox4Input.Text);

                textBox4ResultA.Text = RelationalCalculations.IsFalse(val4) ? SUCCESS : FAIL;
                textBox4ResultB.Text = RelationalCalculations.IsFalse(val4) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox4ResultA.Text = ERROR;
                textBox4ResultB.Text = ERROR;
            }


            //test 5
            try
            {
                decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
                decimal val5B = Convert.ToDecimal(textBox5InputB.Text);

                textBox5ResultA.Text = RelationalCalculations.AreEqual(val5A, val5B) ? SUCCESS : FAIL;
                textBox5ResultB.Text = RelationalCalculations.AreEqual(val5A, val5B) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox5ResultA.Text = ERROR;
                textBox5ResultB.Text = ERROR;
            }


            //test 6
            textBox6ResultA.Text = RelationalCalculations.IsNotJones(textBox6Input.Text) ? SUCCESS : FAIL;
            textBox6ResultB.Text = RelationalCalculations.IsNotJones(textBox6Input.Text) ? SUCCESS : FAIL;


            //test 7
            try
            {
                decimal val7 = Convert.ToDecimal(textBox7Input.Text);

                textBox7ResultA.Text = RelationalCalculations.IsLargerThanZero(val7) ? SUCCESS : FAIL;
                textBox7ResultB.Text = RelationalCalculations.IsLargerThanZero(val7) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox7ResultA.Text = FAIL;
                textBox7ResultB.Text = FAIL;
            }



            //test 8
            try
            {
                decimal val8A = Convert.ToDecimal(textBox8InputA.Text);
                decimal val8B = Convert.ToDecimal(textBox8InputB.Text);

                textBox8ResultA.Text = RelationalCalculations.IsLessThan(val8A, val8B) ? SUCCESS : FAIL;
                textBox8ResultB.Text = RelationalCalculations.IsLessThan(val8A, val8B) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox8ResultA.Text = FAIL;
                textBox8ResultB.Text = FAIL;
            }


            //test 9
            try
            {
                decimal val9 = Convert.ToDecimal(textBox9Input.Text);
                textBox9ResultA.Text = RelationalCalculations.IsLargerOrEqualsThan500(val9) ? SUCCESS : FAIL;
                textBox9ResultB.Text = RelationalCalculations.IsLargerOrEqualsThan500(val9) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox9ResultA.Text = FAIL;
                textBox9ResultB.Text = FAIL;
            }


            //test 10
            try
            {
                decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
                decimal val10B = Convert.ToDecimal(textBox10InputB.Text);

                textBox10ResultA.Text = RelationalCalculations.IsLessOrEqualsThan(val10A, val10B) ? SUCCESS : FAIL;
                textBox10ResultB.Text = RelationalCalculations.IsLessOrEqualsThan(val10A, val10B) ? SUCCESS : FAIL;
            }
            catch (Exception)
            {
                textBox10ResultA.Text = FAIL;
                textBox10ResultB.Text = FAIL;
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "";
            textBox2Input.Text = "";
            textBox3Input.Text = "";
            textBox4Input.Text = "";
            textBox5InputA.Text = "";
            textBox5InputB.Text = "";
            textBox6Input.Text = "";
            textBox7Input.Text = "";
            textBox8InputA.Text = "";
            textBox8InputB.Text = "";
            textBox9Input.Text = "";
            textBox10InputA.Text = "";
            textBox10InputB.Text = "";

            textBox1ResultA.Text = "";
            textBox2ResultA.Text = "";
            textBox3ResultA.Text = "";
            textBox4ResultA.Text = "";
            textBox5ResultA.Text = "";
            textBox6ResultA.Text = "";
            textBox7ResultA.Text = "";
            textBox8ResultA.Text = "";
            textBox9ResultA.Text = "";
            textBox10ResultA.Text = "";

            textBox1ResultB.Text = "";
            textBox2ResultB.Text = "";
            textBox3ResultB.Text = "";
            textBox4ResultB.Text = "";
            textBox5ResultB.Text = "";
            textBox6ResultB.Text = "";
            textBox7ResultB.Text = "";
            textBox8ResultB.Text = "";
            textBox9ResultB.Text = "";
            textBox10ResultB.Text = "";
        }
    }
}
