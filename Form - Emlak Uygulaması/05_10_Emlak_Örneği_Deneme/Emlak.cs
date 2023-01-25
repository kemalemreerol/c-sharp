using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_10_Emlak_Örneği_Deneme
{
     public class Emlak
    {
        public string il { get; set; }
        public string ilce { get; set; }
        public string IsınmaTürü { get; set; }
        public int OdaSayısı { get; set; }
        public int MetreKare { get; set; }

        public string metod1(string ill, string ilcee, string ısınmatürü, int odasayisi, int metrekaree)
        {
            return $"{ill} , {ilcee}, {ısınmatürü}, {odasayisi}, {metrekaree}";
        }


    }

    
    public class Kiralık:Emlak
    {
        public int KiraBedeli { get; set; }
        public string TapuSahibi { get; set; }
    }
    public class Satılık:Emlak
    {
        public int KiraBedeli { get; set; }
        public string TapuSahibi { get; set; }
    }



}
