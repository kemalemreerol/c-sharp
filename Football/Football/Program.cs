using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualBasic;


namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data teamHome = new Data();
            Data teamAway = new Data();



            Data team1 = new Teams(95, 20, "Barcelona", 1);
            Data team2 = new Teams(105, 20, "Real Madrid", 2);
            Data team3 = new Teams(80, 30, "Manchester City", 3);
            Data team4 = new Teams(75, 30, "Bayern Münih", 4);
            Data team5 = new Teams(80, 10, "Chelsea", 5);
            Data team6 = new Teams(95, 10, "Atletico Madrid", 6);
            Data team7 = new Teams(70, 10, "Galatasaray", 7);
            Data team8 = new Teams(50, 5, "Sivasspor", 8);

            //Data team1 = new Data(95, 20, "Barcelona", 1);
            //Data team2 = new Data(105, 20, "Real Madrid", 2);
            //Data team3 = new Data(80, 30, "Manchester City", 3);
            //Data team4 = new Data(75, 30, "Bayern Münih", 4);
            //Data team5 = new Data(80, 10, "Chelsea", 5);
            //Data team6 = new Data(95, 10, "Atletico Madrid", 6);
            //Data team7 = new Data(70, 10, "Galatasaray", 7);
            //Data team8 = new Data(50, 5, "Sivasspor", 8);

            ArrayList myteams = new ArrayList();
            myteams.Add(team1);
            myteams.Add(team2);
            myteams.Add(team3);
            myteams.Add(team4);
            myteams.Add(team5);
            myteams.Add(team6);
            myteams.Add(team7);
            myteams.Add(team8);

            Console.WriteLine("Takımını Seç");
            Console.WriteLine();
            Console.WriteLine("1-" + team1.Getname());
            Console.WriteLine("2-" + team2.Getname());
            Console.WriteLine("3-" + team3.Getname());
            Console.WriteLine("4-" + team4.Getname());
            Console.WriteLine("5-" + team5.Getname());
            Console.WriteLine("6-" + team6.Getname());
            Console.WriteLine("7-" + team7.Getname());
            Console.WriteLine("8-" + team8.Getname());
            int choice1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Rakbini Seç");
            Console.WriteLine("1-" + team1.Getname());
            Console.WriteLine("2-" + team2.Getname());
            Console.WriteLine("3-" + team3.Getname());
            Console.WriteLine("4-" + team4.Getname());
            Console.WriteLine("5-" + team5.Getname());
            Console.WriteLine("6-" + team6.Getname());
            Console.WriteLine("7-" + team7.Getname());
            Console.WriteLine("8-" + team8.Getname());
            int choice2 = int.Parse(Console.ReadLine());



            for (int i = 1; i <= myteams.Count; i++)
            {
                if (choice1 == i)
                {
                    teamHome = (Data)myteams[i - 1];
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (choice2 == i)
                {
                    teamAway = (Data)myteams[i - 1];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{teamHome.Getname()} - {teamAway.Getname()} karşılaşması başlamak üzere.");
            Console.ReadLine();
            Console.WriteLine("Ve maç başladı.");
            Console.ReadLine();

            Random rnd = new Random();
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i <= 90; i += 5)
            {
                int saldir1 = rnd.Next(teamHome.GetattackSuccessRate());
                int savun1 = rnd.Next(teamHome.GetdefenseSuccessRate());

                int saldir2 = rnd.Next(teamAway.GetattackSuccessRate());
                int savun2 = rnd.Next(teamAway.GetdefenseSuccessRate());

                Console.WriteLine($"{teamHome.Getname()} atağı... ");
                Console.ReadLine();
                if (saldir1 > savun2)
                {
                    Console.WriteLine($"GOOOOL. {teamHome.Getname()} attı.");
                    counter1++;
                    Console.WriteLine($"Dakika:{i + 1}  {teamHome.Getname()} {counter1}--{counter2} {teamAway.Getname()} ");
                    Console.ReadLine();
                }
                else if (saldir1 <= savun2)
                {
                    Console.WriteLine($"Dakika:{i + 1} AUT");
                    Console.ReadLine();
                }

                Console.WriteLine($"{teamAway.Getname()} atağı...");
                Console.ReadLine();
                if (saldir2 > savun1)
                {
                    Console.WriteLine($"GOOOL.{teamAway.Getname()} attı.");
                    counter2++;
                    Console.WriteLine($"Dakika:{i + 3}  {teamHome.Getname()} {counter1}--{counter2} {teamAway.Getname()} ");
                    Console.ReadLine();
                }
                else if (saldir2 <= savun1)
                {
                    Console.WriteLine($"Dakika:{i + 3} AUT");
                    Console.ReadLine();
                }

            }
            Console.WriteLine($"Karşılaşma Sona Erdi.");
            Console.WriteLine($"{teamHome.Getname()} {counter1}--{counter2} {teamAway.Getname()} ");
            Console.ReadKey();


        }
    }
}