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
        private string customerName;
        private Customer customer;
        
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(string name, Customer c) : this()
        {
            customerName = name;
            label2.Text = "Customer Banking App for " + customerName;
            this.customer = c;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = comboBox1.SelectedIndex;
            if (selection == 0)
            {
                label5.Text = "EveryDay Account: $" + customer.Balance;
            }
            else if (selection == 1)
            {
                label5.Text = "You have selected Investment Account";
            }
            else if(selection == 2)
            {
                label5.Text = "You have selected Omni Account";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedAccountType = comboBox1.SelectedIndex;
            int selectedTransactionType = comboBox2.SelectedIndex;
            double value = Convert.ToDouble(transactionValue.Text);
            double balance = customer.Balance;

            //Deposit
            if(selectedTransactionType == 0)
            {
                //Do stuff for Everyday account deposits
                if(selectedAccountType == 0)
                {
                    EverydayAccount account = new EverydayAccount(value, balance, selectedTransactionType);
                    customer.Balance = account.Balance;
                    label5.Text = "New Balance is " + customer.Balance;
                    //label5.Text = "New Balance is " + account.Balance;
                    //label5.Text = "New Balance is " + account.Balance;
                }
            }
            //Withdrawal
            if(selectedTransactionType == 1)
            {
                //Do stuff for everyday account withdrawals
                if(selectedAccountType == 0)
                {
                    EverydayAccount account = new EverydayAccount(value, balance, selectedTransactionType);
                    if(account.failed == true)
                    {
                        label5.Text = "You have insufficient funds in your account! " + customer.Balance;
                    }
                    else
                    {
                        customer.Balance = account.Balance;
                        label5.Text = "New Balance is $" + customer.Balance;
                    }
                }
            }
        }
    }
}
