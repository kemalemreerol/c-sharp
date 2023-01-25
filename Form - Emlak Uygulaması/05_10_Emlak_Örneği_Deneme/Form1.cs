namespace _05_10_Emlak_Örneği_Deneme
{   
    

    public partial class Form1 : Form
    {

        public void metodYazdırma(string ill, string ilcee, string ısınmatürüü, int odasayısıı, int metrekaree,int fiyatt,string evsahibi)
        {
            yazdır.Text = $"İl: {ill} , İlçe:{ilcee} , Isınma Türü: {ısınmatürüü} , Oda Sayısı: {odasayısıı} , Metrekare: {metrekaree} , Alıcı İsmi: {evsahibi} , Fiyat: {fiyatt}";
        }

        public Form1()
        {
            InitializeComponent();

            Emlak emlak = new Emlak();
            Satılık satılık = new Satılık();
            Kiralık kiralık = new Kiralık();

            //satılık.il = "";
            //satılık.MetreKare = ;
            //satılık.ilce = "Beşiktaş";
            //satılık.IsınmaTürü = "Doğal Gaz";
            //satılık.OdaSayısı = 5;

            //kiralık.il ="Ankara";
            //kiralık.ilce ="Kızılay";
            //kiralık.MetreKare =100;
            //kiralık.OdaSayısı =10;
            //kiralık.IsınmaTürü ="Yerden Isıtmalı";

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kiralık");
            comboBox1.Items.Add("Satılık");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                 label6.Visible = true;
                label8.Visible = false;
                yazdır.Text = "";

            }
            else 
            {
                label6.Visible = false;
                label8.Visible = true;
                yazdır.Text = "";

            }

        }

        private void buton1_Click(object sender, EventArgs e)
        {
            Emlak emlak = new Emlak();
            Satılık satılık = new Satılık();
            Kiralık kiralık = new Kiralık();

            if (comboBox1.SelectedIndex==0)
            {
                kiralık.il = textBox1.Text;
                kiralık.ilce = textBox2.Text;
                kiralık.OdaSayısı = int.Parse(textBox3.Text);
                kiralık.IsınmaTürü = textBox4.Text;
                kiralık.MetreKare = int.Parse(textBox5.Text);
                kiralık.TapuSahibi = textBox6.Text;
                kiralık.KiraBedeli =int.Parse(textBox7.Text);

                metodYazdırma(kiralık.il, kiralık.ilce, kiralık.IsınmaTürü, kiralık.OdaSayısı, kiralık.MetreKare, kiralık.KiraBedeli, kiralık.TapuSahibi);

                yazdır.Text = emlak.metod1(kiralık.il, kiralık.ilce, kiralık.IsınmaTürü, kiralık.OdaSayısı, kiralık.MetreKare);

                
            }
            else
            {
                satılık.il = textBox1.Text;
                satılık.ilce = textBox2.Text;
                satılık.OdaSayısı=int.Parse(textBox3.Text);
                satılık.IsınmaTürü = textBox4.Text;
                satılık.MetreKare=int.Parse(textBox5.Text);
                satılık.TapuSahibi = textBox6.Text;
                satılık.KiraBedeli = int.Parse(textBox7.Text);

                metodYazdırma(satılık.il, satılık.ilce, satılık.IsınmaTürü, satılık.OdaSayısı, satılık.MetreKare,satılık.KiraBedeli, satılık.TapuSahibi);

            }



           




        }
    }
}