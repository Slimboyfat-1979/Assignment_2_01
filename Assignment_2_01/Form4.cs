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
    public partial class Form4 : Form1
    {
        string customerName;

        Controller control = Form3.getController();
        Form3 form3 = new Form3();
        Form2 form2 = new Form2();
        public Form4()
        {
            InitializeComponent();
        }

        private void customerEntrySubmit_Click(object sender, EventArgs e)
        {
            
            //Get the text from the list box and add to customer list;
            customerName = customerEntry.Text;
            Customer temp = new Customer(customerName);
            int IdNumber = temp.getID();
            control.customerList.Add(temp);
            //control.customerList.Add(new Customer(customerName));
            
            //Fix to get the name and id of the person just added;
            //MessageBox.Show("Customer: " + Convert.ToString(control.customerList[IdNumber].getID()) + " " + control.customerList[IdNumber].Name + " Added");
            this.Hide();
            form3.getForm3().DisplayCustomers();
            form3.Show();
            
        }
    }
}
