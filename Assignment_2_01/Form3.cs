using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_01
{
    public partial class Form3 : Form1
    {
        //Main controller object that other classes can retrieve using the public get method
        private static Controller control = new Controller();

        public static Controller getController()
        {
            return control;
        }
        public Form3()
        {
            //Figure out how to read customer only once
            InitializeComponent();
            ReadCustomers(getController());
            //DisplayCustomers();
        }

        public Form3 getForm3()
        {
            return this;
        }

        public void ReadCustomers(Controller c)
        {
            Customer t;
            var reader = new StreamReader("customer.txt");
            while (!reader.EndOfStream)
            {
                t = new Customer(reader.ReadLine());
                c.customerList.Add(t);
            }
            DisplayCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newCustomer = new Form4();
            this.Hide();
            newCustomer.Show();
        }

        public void DisplayCustomers()
        {
            customerListBox.Items.Clear();
            foreach(Customer c in control.customerList)
            {
                customerListBox.Items.Add(c.getID() + " " + c.Name);
                
            }
            
            customerListBox.SelectedItem = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedID = customerListBox.SelectedIndex;
            Customer temp = control.customerList[selectedID];
            Form5 form5 = new Form5();
            form5.createTempCustomer(temp);
            this.Hide();
            form5.Show();


            //MessageBox.Show(Convert.ToString(selectedID));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
