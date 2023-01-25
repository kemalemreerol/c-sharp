using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Teams : Data
    {
        public Teams(int defenseSuccessRate, int attackSuccessRate, string name, int no) : base(defenseSuccessRate, attackSuccessRate, name, no)
        {

        }
        //public override void showOverall()
        //{
        //    Console.WriteLine($"{Getname()}    Defense - Attack Success Rates:  {this.defenseSuccessRate} - {this.attackSuccessRate}");

        //}



    }

}
