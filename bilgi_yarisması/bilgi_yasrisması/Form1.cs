namespace bilgi_yasrisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlış = 0;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button5.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            label4.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "irem kaya kaç yılında dogdu";
                button1.Text = "1923";
                button2.Text = "2005";
                button3.Text = "3046";
                button4.Text = "2015";
                label7.Text = "2005";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "irem kaya'nın en sevdigi renk nedir";
                button1.Text = "mor";
                button2.Text = "turuncu";
                button3.Text = "kırmızı";
                button4.Text = "irem kaya her rengi sever";
                label7.Text = "irem kaya her rengi sever";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "irem kaya'nın kedisinin ismi nedir";
                button1.Text = "garip kont";
                button2.Text = "pulsar";
                button3.Text = "BADEM";
                button4.Text = "yalan dunya selahattin";
                label7.Text = "BADEM";
                button5.Text = "game over";
            }
            if (soruno == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                button5.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "Yanlış:" + yanlış);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;



            label8.Text = button1.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button2.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlış++;
                label6.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlış++;
                label6.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;


            }
            else
            {
                yanlış++;
                label6.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
