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
            Dövüscü dövüscü = new();
            Assasin assasin = new();
            Büyücü büyücü = new();
            Tank tank = new();

            dövüscü.Can = 500;
            dövüscü.SaldýrýGücü = 90;
            dövüscü.Iskalama = 15;

            label1.Text = dövüscü.Can.ToString();
            label2.Text = dövüscü.SaldýrýGücü.ToString();
            label3.Text = dövüscü.Iskalama.ToString();

            assasin.Can = 470;
            assasin.SaldýrýGücü = 110;
            assasin.Iskalama = 12;

            label4.Text = assasin.Can.ToString();
            label5.Text = assasin.SaldýrýGücü.ToString();
            label6.Text = assasin.Iskalama.ToString();

            büyücü.Can = 430;
            büyücü.SaldýrýGücü = 150;
            büyücü.Iskalama = 9;

            label7.Text = büyücü.Can.ToString();
            label8.Text = büyücü.SaldýrýGücü.ToString();
            label9.Text = büyücü.Iskalama.ToString();

            tank.Can = 650;
            tank.SaldýrýGücü = 80;
            tank.Iskalama = 8;

            label10.Text = tank.Can.ToString();
            label11.Text = tank.SaldýrýGücü.ToString();
            label12.Text = tank.Iskalama.ToString();
        }
        public string pcHeroSecim()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);

            if (random == 0)
            {
                return $"Dövüþcü ";
            }
            else if (random == 1)
            {
                return $"Asassin ";
            }
            else if (random == 2)
            {
                return $"Büyücü ";
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
                button1.Text = $"Dövüþcü Seçimi Yaptýnýz.\nBilgisayar ise {pcHeroSecim()} Seçimi Yaptý.";
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                button1.Text = $"Assasin Seçimi Yaptýnýz.\nBilgisayar ise {pcHeroSecim()} Seçimi Yaptý.";
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)
            {
                button1.Text = $"Büyücü Seçimi Yaptýnýz.\nBilgisayar ise {pcHeroSecim()} Seçimi Yaptý.";
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)
            {
                button1.Text = $"Tank Seçimi Yaptýnýz.\nBilgisayar ise {pcHeroSecim()} Seçimi Yaptý.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userHeroSecim();


        }
    }
}