namespace degisken_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string irem;
            //irem = "merhaba badem";
            //label1.Text = irem;
            //string ad;
            //ad = "irem kaya";
            //label1.Text = ad;
            //string meslek;
            // meslek = "yazýlýmcý";
            //label2.Text = meslek;
            string sehir;
            sehir = textBox1.Text;
            label1.Text = sehir;

        }
    }
}
