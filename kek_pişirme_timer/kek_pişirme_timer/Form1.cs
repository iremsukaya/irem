namespace kek_pişirme_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                button1.Visible = false;
                this.BackColor = Color.LightYellow;
                MessageBox.Show("Kek Malzemeleri Karıştırıldı!");
                button2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {

                timer1.Stop();
                timer2.Start();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value == 100)
            {
                button2.Visible = false;
                this.BackColor = Color.SandyBrown;
                MessageBox.Show("KEK PİŞTİ!");
                button3.Enabled = true;


            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value == 100)
            {
                timer2.Stop();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value == 100)
            {
                button3.Visible = false;
                this.BackColor = Color.SlateGray;
                MessageBox.Show("KEK YENDİ!");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
