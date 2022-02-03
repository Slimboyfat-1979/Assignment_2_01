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
        double newEBalance;
        double newIBalance;
        double newOBalance;

        Controller control = Form3.getController();
        Form3 form3 = new Form3();
        Customer temp;
        public Form4()
        {
            InitializeComponent();
        }

        private void customerEntrySubmit_Click(object sender, EventArgs e)
        {
            customerName = customerEntry.Text;
            newEBalance = Convert.ToDouble(customerBalanceEntry.Text);
            newIBalance = Convert.ToDouble(textBox1.Text);
            newOBalance = Convert.ToDouble(textBox2.Text);
            temp = new Customer(customerName, newEBalance, newIBalance, newOBalance);
            control.customerList.Add(temp);
            this.Hide();
            form3.DisplayCustomers();
            form3.Show();
        }
    }
}
