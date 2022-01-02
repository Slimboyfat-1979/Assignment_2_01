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
    public partial class Form6 : Form1
    {
        Controller control = Form3.getController();
        Customer temp;
        public Form6()
        {
            InitializeComponent();
        }

        public void createTempCustomer(Customer c)
        {
            temp = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = customerRemoveBox.Text;
            control.removeCustomer(name, temp);
            this.Hide();
            
        }
    }
}
