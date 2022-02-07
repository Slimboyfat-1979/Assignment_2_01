using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01
{
    //Test to see whether or not I can succesfully pull this and make it work
    public class Controller
    {
        //List to hold customers that are created
        public List<Customer> customerList = new List<Customer>();

        //Controller to load up information
        public void customerInformation()
        {
            string[] array;
            StreamReader file = new StreamReader("/details4.txt");
            while (!file.EndOfStream)
            {
                array = file.ReadLine().Split(',');
                string name = array[0];
                double eBalance = Convert.ToDouble(array[1]);
                double iBalance = Convert.ToDouble(array[2]);
                double oBalance = Convert.ToDouble(array[3]);

                Customer c = new Customer(name, eBalance, iBalance, oBalance);
                customerList.Add(c);
            }
        }
        public void updateCustomerName(Customer c, string name)
        {
            if (customerList.Contains(c))
            {
                c.Name = name;
            }
        }

        public void removeCustomer(Customer temp, int selectedID)
        {
            if (customerList.Contains(temp))
            {
                customerList.RemoveAt(selectedID);
            }
        }

        public double deposit(double value, double balance)
        {
            balance = balance + value;
            return balance;
        }

        public double withdrawal(double value, double balance)
        {
            if (failedWithdrawal(value, balance))
            {
                
                throw new FailedWithdrawalException("Transaction exceeds funds available \n Your balance is only $" + balance);
                
            }
            else
            {
                balance = balance - value;
                return balance;
            }
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
