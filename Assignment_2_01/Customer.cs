using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Controller Class

namespace Assignment_2_01
{
    public class Customer
    {
        public List<Customer> cusomerList = new List<Customer>();

        private static int nextID = 1;
        private int ID;

        public int getID()
        {
            return ID;
        }

        public double eBalance { get; set; }

        public double iBalance { get; set; }

        public double oBalance { get; set; }

        public string Name { get; set; }
       
        public Customer(string name, double eBalance, double iBalance, double oBalance)
        {
            this.Name = name;
            this.eBalance = eBalance;

            double iBalanceWithInterest = iBalance * InvestmentAccount.interestRate;
            this.iBalance = iBalance + iBalanceWithInterest;
            
            //Do the same for this one
            if(oBalance >= 1000)
            {
                double oBalanceWithInterest = oBalance * InvestmentAccount.interestRate;
                this.oBalance = oBalance + oBalanceWithInterest + OmniAccount.getOverdraft();
            }
            else
            {
                this.oBalance = oBalance + OmniAccount.getOverdraft();
            }

            ID = nextID;
            nextID++;
        }

    }
}
