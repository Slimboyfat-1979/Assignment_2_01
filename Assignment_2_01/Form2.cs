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
    public partial class Form2 : Form1
    {
       public static Form3 menuForm = new Form3();
        private Controller c = Form3.getController();
        public Form2()
        {
            InitializeComponent();
        }

        public Form3 getMenuForm()
        {
            return menuForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 menuForm = new Form3();
            menuForm.ReadCustomers(c);
            this.Hide();
            menuForm.Show();
        }
    }
}
