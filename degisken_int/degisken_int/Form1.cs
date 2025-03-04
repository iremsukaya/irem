namespace degisken_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayi;
            //sayi = 20;
            //label1.Text = sayi.ToString();

            int sayi1, sayi2, toplam;
            //sayi1 = 10;
            // sayi2 = 20;
            // toplam = sayi1 + sayi2;
            //  label1.Text = toplam.ToString();

            int kenar, alan, çevre;
            kenar = 4;
            alan = kenar * 4;
            çevre = kenar * 4;
            label1.Text=alan.ToString();

        }
    }
}
