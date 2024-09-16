namespace MayTinhCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        double num1 = 0, num2 = 0;
        double result;
        string option;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + ".";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show(" Hay nhap mot so truoc", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    option = "+";
                    num1 = double.Parse(txtTotal.Text);
                    txtTotal.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai quy tac", "Loi phat sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show(" Hay nhap mot so truoc", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    option = "-";
                    num1 = double.Parse(txtTotal.Text);
                    txtTotal.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai quy tac", "Loi phat sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show(" Hay nhap mot so truoc", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    option = "x";
                    num1 = double.Parse(txtTotal.Text);
                    txtTotal.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai quy tac", "Loi phat sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show(" Hay nhap mot so truoc", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    option = "/";
                    num1 = double.Parse(txtTotal.Text);
                    txtTotal.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai quy tac", "Loi phat sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show(" Hay nhap mot so truoc", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    option = "%";
                    num1 = double.Parse(txtTotal.Text);
                    txtTotal.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai quy tac", "Loi phat sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show(" Hay nhap mot so truoc", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    num2 = double.Parse(txtTotal.Text);
                    if (option == "+") result = num1 + num2;
                    if (option == "-") result = num1 - num2;
                    if (option == "x") result = num1 * num2;
                    if (option == "/" && num2 != 0) result = num1 / num2;
                    if (option == "%") result = num1 % num2;
                    if (option == "/" && num2 == 0)
                    {
                        MessageBox.Show("Khong the chia cho 0", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else txtTotal.Text = result.ToString("F5");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Tran so hoc", "Loi phat sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Opps: {ex.Message}", "Somethings went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }
    }
}
