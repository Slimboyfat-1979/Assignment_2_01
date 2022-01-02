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

        public void addTempCustomer(Customer c, string name)
        {
             temp = new Customer(name); 
        }

        public Customer getTempCustomer()
        {
            return temp;
        }

        //Add Exception the Else statement if there customer is not selected
        public void updateCustomerName(string name, Customer temp)
        {
            if (customerList.Contains(temp))
            {
                temp.Name = name;
            }
        }

        //Add exception here also
        public void removeCustomer(string name, Customer c)
        {
            if (customerList.Contains(c))
            {
                customerList.Remove(c);
            }
            else
            {

            }
        }
    }
}
