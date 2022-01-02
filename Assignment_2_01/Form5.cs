using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_01
{
    public partial class Form5 : Form1
    {
        Controller control = Form3.getController();
        Form3 form3 = new Form3();
        Customer temp;
       
        public Form5()
        {
            InitializeComponent();
        }

        //Add this to the controller?
        /*
        public void createTempCustomer(Customer c)
        {
            temp = c;
        }
        */

        public void createTempCustomer(Customer c)
        {
            temp = c;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Customer temp;
            string name = customerNameEdit.Text;
            //temp = controller.addTempCustomer(name);
            controller.updateCustomerName(temp, name);
            */

            string name = customerNameEdit.Text;
            Customer temp = this.temp;
            control.updateCustomerName(name, temp);
            //control.updateCustomerName(name);
            //Retrieve the customer object;
            //Customer t = controller.getTempCustomer();
            //controller.updateCustomerName(t, name);
            //controller.updateCustomerName(name);

            this.Hide();
            form3.DisplayCustomers();
            form3.Show();
        }
    }
}
