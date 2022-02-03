using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01
{
    public class OmniAccount : InvestmentAccount
    {
        private const double overdraft = 500.00;

        public static double getOverdraft()
        {
            return overdraft;
        }
        public OmniAccount(double value, double balance, int transactionType) : base(value, balance, transactionType)
        {
            
        }
    }
}
