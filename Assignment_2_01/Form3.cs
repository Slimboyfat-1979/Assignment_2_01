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
            InitializeComponent();  
        }

        public Form3 getForm3()
        {
            return this;
        }

        //Remember to put the data in the right location so that it can read the file, currently in root directory
        public void ReadCustomers(Controller c)
        {
            Customer t = null;
            string[] array;
            var reader = new StreamReader("/Details.txt");
            while (!reader.EndOfStream)
            {
                array = reader.ReadLine().Split(',');
                string name = array[0];
                double balance = Convert.ToDouble(array[1]);
                t = new Customer(name, balance);
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
            customerListBox.Items.Add("ID\t Name\t\t Balance \n\n");
            foreach(Customer c in control.customerList)
            {
                customerListBox.Items.Add(c.getID() + "\t" + c.Name + "\t\t" + c.Balance);
                
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

        }

        //Button to remove customer
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedId = customerListBox.SelectedIndex;
            
            Customer temp = control.customerList[selectedId];
            DialogResult dialogResult = MessageBox.Show("Would You Like To Remove Customer: " + temp.Name + "?", "Remove Customer?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                control.removeCustomer(temp, selectedId);
                customerListBox.Items.RemoveAt(selectedId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer temp = control.customerList[customerListBox.SelectedIndex-1];
            Form6 form6 = new Form6(temp.Name, temp); 
            form6.Show();
            this.Hide();
        }
    }
}
