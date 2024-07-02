namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = 0;
            if (radioButton1.Checked == true) //plus

            {
                result = num1 + num2;

            }
            else if (radioButton2.Checked == true)//plus
            {
                result = num1 - num2;
            }
            else if (radioButton3.Checked == true)//plus
            {
                result = num1 * num2;
            }
            else if (radioButton3.Checked == true)//plus
            {

                result = (num1 / num2);
            }
            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


