namespace savasoyunudeneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SavasOyunu savasoyunu = new();
            D�v�sc� d�v�sc� = new();
            Assasin assasin = new();
            B�y�c� b�y�c� = new();
            Tank tank = new();

            d�v�sc�.Can = 500;
            d�v�sc�.Sald�r�G�c� = 90;
            d�v�sc�.Iskalama = 15;

            label1.Text = d�v�sc�.Can.ToString();
            label2.Text = d�v�sc�.Sald�r�G�c�.ToString();
            label3.Text = d�v�sc�.Iskalama.ToString();

            assasin.Can = 470;
            assasin.Sald�r�G�c� = 110;
            assasin.Iskalama = 12;

            label4.Text = assasin.Can.ToString();
            label5.Text = assasin.Sald�r�G�c�.ToString();
            label6.Text = assasin.Iskalama.ToString();

            b�y�c�.Can = 430;
            b�y�c�.Sald�r�G�c� = 150;
            b�y�c�.Iskalama = 9;

            label7.Text = b�y�c�.Can.ToString();
            label8.Text = b�y�c�.Sald�r�G�c�.ToString();
            label9.Text = b�y�c�.Iskalama.ToString();

            tank.Can = 650;
            tank.Sald�r�G�c� = 80;
            tank.Iskalama = 8;

            label10.Text = tank.Can.ToString();
            label11.Text = tank.Sald�r�G�c�.ToString();
            label12.Text = tank.Iskalama.ToString();
        }
        public string pcHeroSecim()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);

            if (random == 0)
            {
                return $"D�v��c� ";
            }
            else if (random == 1)
            {
                return $"Asassin ";
            }
            else if (random == 2)
            {
                return $"B�y�c� ";
            }
            else
            {
                return $"Tank ";
            }
            return "";

        }
        public void userHeroSecim()
        {


            if (checkBox1.Checked==true && checkBox2.Checked==false && checkBox3.Checked==false && checkBox4.Checked==false)
            {
                button1.Text = $"D�v��c� Se�imi Yapt�n�z.\nBilgisayar ise {pcHeroSecim()} Se�imi Yapt�.";
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                button1.Text = $"Assasin Se�imi Yapt�n�z.\nBilgisayar ise {pcHeroSecim()} Se�imi Yapt�.";
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)
            {
                button1.Text = $"B�y�c� Se�imi Yapt�n�z.\nBilgisayar ise {pcHeroSecim()} Se�imi Yapt�.";
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)
            {
                button1.Text = $"Tank Se�imi Yapt�n�z.\nBilgisayar ise {pcHeroSecim()} Se�imi Yapt�.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userHeroSecim();


        }
    }
}