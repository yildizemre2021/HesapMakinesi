namespace HesapMakinesi
{
    public partial class Form1 : Form
    {

        static int birinciSayi = 0;
        static int sonuc = 0;
        static bool hafiza = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            hesapAlani.Text += "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            hesapAlani.Text += "2"; 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            hesapAlani.Text += "3"; 
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            hesapAlani.Text += "4"; 
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            hesapAlani.Text += "5"; 
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            hesapAlani.Text += "6"; 
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            hesapAlani.Text += "7"; 
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            hesapAlani.Text += "8"; 
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            hesapAlani.Text += "9"; 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(hesapAlani.Text != "")
                hesapAlani.Text += "0"; 
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            hesapAlani.Clear();
            islem1.Text = "";
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            if(hafiza == false)
            {
                birinciSayi = int.Parse(hesapAlani.Text);
                islem1.Text = hesapAlani.Text + "+";
                hesapAlani.Clear();
                hafiza = true;
            }
            else
            {
                sonuc = birinciSayi + int.Parse(hesapAlani.Text);
                hesapAlani.Clear();
                hesapAlani.Text = sonuc.ToString();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}