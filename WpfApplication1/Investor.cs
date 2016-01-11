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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Summ { get; set; }
        public string City { get; set; }

        private ObservableCollection<Investor> _investorsList = null;
        public ObservableCollection<Investor> InvestorsList
        {
            get
            {
                if(_investorsList!= null)
                {
                    return _investorsList;
                }
                _investorsList = new ObservableCollection<Investor>();
                _investorsList.Add(new Investor()
                {
                    FirstName = "Jhon",
                    LastName = "Doe",
                    Summ = 100000,
                    City = "Budapesht"
                });
                return _investorsList;
            }

        }

    }
}
