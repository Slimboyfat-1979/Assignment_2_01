using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_01
{
    public class EverydayAccount
    {
        Controller c = Form3.getController();
        public bool failed;

        public double Balance { get; set; }

        public EverydayAccount(double value, double balance, int transactionType)
        {
            if(transactionType == 0)
            {
                Balance = c.deposit(value, balance);
            }
           
            if(transactionType == 1)
            {
                try
                {
                    Balance = c.withdrawal(value, balance);
                }
                catch(FailedWithdrawalException e)
                {
                    MessageBox.Show(e.Message);
                }
            }   
        }
    }
}
