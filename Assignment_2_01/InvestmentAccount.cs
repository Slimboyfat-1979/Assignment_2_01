using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01
{
    public class InvestmentAccount : EverydayAccount
    {
        public static double interestRate = 0.02;
        public static double failedFee = 10.00;
        Controller c = Form3.getController();

        public InvestmentAccount(double value, double balance, int transactionType) : base(value, balance, transactionType)
        {
           //Calculates the balance for this account with the set interest rate
            this.Balance = Balance + calculateBalanceWithInterest(Balance); 
        }

        //Method to calculate interest
        public double calculateBalanceWithInterest(double balance)
        {
            double balanceWithInterest = balance * interestRate;
            return balanceWithInterest;
        }
    }
}
