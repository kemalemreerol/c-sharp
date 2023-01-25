using System;
using System.Collections;
using System.Linq;
using System.Xml.Schema;

namespace Champions_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            ArrayList torba1 = new ArrayList()
            { "Barcelona","Real Madrid","Manchester City","Liverpool","Chelsea","Paris Saint Germain","Juventus","Bayern Munih"};
         
            ArrayList torba2 = new ArrayList()
            {"Atletico Madrid","Sevilla","Manchester United","Arsenal","Tottenham","Inter","Milan","Borussia Dortmund"};
           
            ArrayList torba3 = new ArrayList()
            {"Napoli","Roma","Lyon","Marsilya","Leipzig","Bayer Leverkusen","Ajax","Porto"};
            
            ArrayList torba4 = new ArrayList()
            {"Galatasaray","Benfica","Shakhtar Donetsk","Loserbahçe","PSV Eindhoven","Zenit","Olympiacos","Beşiktaş"};
                                  
            Random random = new Random();
            char sayac = 'A';

            Console.WriteLine("CHAMPIONS LEAGUE GROUP STAGE");
            Console.WriteLine();
            Console.ReadLine();

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    int rastgele1 = random.Next(torba1.Count);                  
                    int rastgele2 = random.Next(torba2.Count);                   
                    int rastgele3 = random.Next(torba3.Count);                   
                    int rastgele4 = random.Next(torba4.Count);
                   
                    Console.Write($"{sayac} Grubu: {torba1[rastgele1]}--{torba2[rastgele2]}--{torba3[rastgele3]}--{torba4[rastgele4]}");
                    torba1.RemoveAt(rastgele1);
                    torba2.RemoveAt(rastgele2);
                    torba3.RemoveAt(rastgele3);
                    torba4.RemoveAt(rastgele4);
                    Console.WriteLine();
                    sayac++;
                    Console.ReadLine();


                    
                }

            }
        }
       

    }
}