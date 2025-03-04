namespace degiskenler_double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 4.25;
            label1.Text = sayi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3, ortalama;
            sayi1 = 70.5;
            sayi2 = 80.3;
            sayi3 = 20.8;
            ortalama = (sayi1 + sayi1 + sayi2) / 3;
            label2.Text = ("ortalama: " + ortalama.ToString());



        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi=Convert.ToDouble(textBox1.Text);
            label3.Text = sayi.ToString();
            
           
        }
    }
}
