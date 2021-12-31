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
        Controller controller = Form3.getController();
        Form3 form3 = new Form3();
        Customer temp;
        public Form5()
        {
            InitializeComponent();
        }

        public void createTempCustomer(Customer c)
        {
            temp = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = customerNameEdit.Text;
            controller.updateCustomerName(temp, name);
            
            this.Hide();
            form3.DisplayCustomers();
            form3.Show();
        }
    }
}
