using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace WpfApplication1
{
   public class Investor
    {
        public string FirstName;
        public string LastName;
        public float Summ;
        public string City;

        public Investor(string FirstName, string LastName, float Summ, string City)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Summ = Summ;
            this.City = City;
        }


    }
}


