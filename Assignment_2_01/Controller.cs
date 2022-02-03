using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01
{
    public class Controller
    {
        //List to hold customers that are created
        public List<Customer> customerList = new List<Customer>();
        Customer temp;

        /*
        public void addTempCustomer(Customer c, string name)
        {
            if (customerList.Contains(c))
            {
                c.Name = name;
            }
            else
            {
                
            }
        }

        public double deposit(double balance, double value)
        {
            balance = balance + value;
            return balance;
        }

        public double withdrawal(double value, double balance)
        {
            balance = balance - value;
            return balance;
        }

        public bool failedWithdrawal(double value, double balance)
        {
            if(value > balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
