namespace CalculatingAverage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(textBox1.Text);
            int number2 = Int32.Parse(textBox2.Text);
            int number3 = Int32.Parse(textBox3.Text);

            double average = (number1 + number2 + number3);
            average = average / 3;

            //Other way to have double values
            //double average = (Double)(number1 + number2 + number3) / 3; 

            MessageBox.Show("The average between this three numbers is: " + average)
        }
    }
}