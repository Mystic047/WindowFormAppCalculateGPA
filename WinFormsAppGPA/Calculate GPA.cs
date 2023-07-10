

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int sumcredit = 0;
        private decimal sumavalcredit1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                decimal number1 = decimal.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                decimal result = number1 * number2;
                textBox3.Text = result.ToString();
                count++;
                sumcredit = sumcredit + number2;
                textBox4.Text = count.ToString();
                sumavalcredit1 = sumavalcredit1 += result;

                decimal GPA = sumavalcredit1 / sumcredit;







                textBox5.Text = sumavalcredit1.ToString();
                textBox6.Text = sumcredit.ToString();
                textBox7.Text = GPA.ToString("0.00");


            }


            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            sumcredit = 0;
            sumavalcredit1 = 0;




            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}