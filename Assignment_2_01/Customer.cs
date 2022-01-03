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
        //Queue<int> IdQueue = new Queue<int>();

        private static int nextID = 1;
        private int ID;

        public int getID()
        {
            return ID;
        }
       
        public string Name { get; set; }
       
        public Customer(string name)
        {
            this.Name = name;
            ID = nextID;
            nextID++;
            
        }

    }
}
