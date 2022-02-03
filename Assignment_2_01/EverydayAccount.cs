using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01
{
    public class EverydayAccount
    {
        Controller c = Form3.getController();
        public bool failed;

        private int Id;
        private static int nextId = 1;

        public double Balance { get; set; }

        public EverydayAccount(double value, double balance, int transactionType)
        {
            if(transactionType == 0)
            {
                Balance = c.deposit(value, balance);
            }
           
            if(transactionType == 1)
            {
                //Balance = c.withdrawal(value, balance);
                failed = c.failedWithdrawal(value, balance);
                if(failed == false)
                {
                    Balance = c.withdrawal(value, balance);
                }   
            }   
        }
    }
}
