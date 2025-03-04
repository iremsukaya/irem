namespace ödevdegisken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            ad = textBox1.Text;
            string soyad;
            soyad = textBox2.Text;
            string yaş;
            yaş=maskedTextBox1.Text;
            listBox1.Items.Add(textBox1.Text);
            
        }
    }
}
