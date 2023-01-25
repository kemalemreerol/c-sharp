using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football

{
    public class Data
    {
        public string name;
        public int defenseSuccessRate;       
        public int attackSuccessRate;
        public int No;

        public Data()
        {

        }

        public Data(int defenseSuccessRate, int attackSuccessRate, string name, int No)
        {
            this.defenseSuccessRate = defenseSuccessRate;
            this.attackSuccessRate = attackSuccessRate;
            this.name = name;
            this.No = No;
        }

        public string Getname() => name;
        //{
        //    return name;
        //}
       

        public int GetdefenseSuccessRate() => defenseSuccessRate;
        //{ return defenseSuccessRate; }     
        
        public int GetattackSuccessRate() => attackSuccessRate;
        //{
        //  return attackSuccessRate;
        //}

        //public virtual void showOverall ()
        //{            
        //    Console.WriteLine($"Defense - Attack Success Rates: { this.defenseSuccessRate} {this.attackSuccessRate}");                     
        //}

        
        public void sdsad()
        {
            
        }

       
    }

          
}

