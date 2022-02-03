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
        double newBalance;

        Controller control = Form3.getController();
        Form3 form3 = new Form3();
        public Form4()
        {
            InitializeComponent();
        }

        private void customerEntrySubmit_Click(object sender, EventArgs e)
        {
            customerName = customerEntry.Text;
            newBalance = Convert.ToDouble(customerBalanceEntry.Text);
            Customer temp = new Customer(customerName, newBalance);
            int IdNumber = temp.getID();
            control.customerList.Add(temp);
            
            MessageBox.Show("Customer: " + Convert.ToString(control.customerList[IdNumber-1].getID()) + " " + control.customerList[IdNumber-1].Name + " Added");
            this.Hide();
            form3.getForm3().DisplayCustomers();
            form3.Show();
            
        }
    }
}
