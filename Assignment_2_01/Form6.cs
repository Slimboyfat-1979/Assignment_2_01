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
                label5.Text = "EveryDay Account: $" + String.Format("{0:0.00}", customer.eBalance);
            }
            else if (selection == 1)
            {
                label5.Text = "Invesment Account: $" + String.Format("{0:0.00}", customer.iBalance);
            }
            else if(selection == 2)
            {
                label5.Text = "Omni Account: $" + String.Format("{0:0.00}", customer.oBalance);
            }
        }

        //Submit button for when the user selects an account type and transaction type
        private void button1_Click(object sender, EventArgs e)
        {
            double balance;
            int selectedAccountType = comboBox1.SelectedIndex;
            int selectedTransactionType = comboBox2.SelectedIndex;
            double value = Convert.ToDouble(transactionValue.Text);

            switch (selectedAccountType)
            {
                case 0:
                    balance = customer.eBalance;
                    break;
                case 1:
                    balance = customer.iBalance;
                    break;
                case 2:
                    balance = customer.oBalance;
                    break;
                default:
                    balance = -1;
                    break;
            }

            //Deposits
            if(selectedTransactionType == 0)
            {
                //Everyday account despoits
                if(selectedAccountType == 0)
                {
                    EverydayAccount account = new EverydayAccount(value, balance, selectedTransactionType);
                    customer.eBalance = account.Balance;
                    label5.Text = "New Balance is $" + Math.Round(customer.eBalance,2);
                    
                }
                //Incvestment account deposits
                if(selectedAccountType == 1)
                {
                    EverydayAccount account = new InvestmentAccount(value, balance, selectedTransactionType);
                    customer.iBalance = account.Balance;
                    label5.Text = "New Balance is $" + Math.Round(customer.iBalance,2);
                }
                //Omni account deposits
                if(selectedAccountType == 2)
                {
                    EverydayAccount account = new OmniAccount(value, balance, selectedTransactionType);
                    customer.oBalance = account.Balance;
                    label5.Text = "New Balance is $" + Math.Round(customer.oBalance);
                }
            }

            //Withdrawals
            if(selectedTransactionType == 1)
            {
                //Everday account withdrawals
                if(selectedAccountType == 0)
                {
                    EverydayAccount account = new EverydayAccount(value, balance, selectedTransactionType);
                    
                    /*
                    if(account.failed == true)
                    {
                        //throw new FailedWithdrawalException("You have insuffcient funds in your account \n Your balance is " + String.Format("{0:0.00}", customer.eBalance));
                        label5.Text = "You have insufficient funds in your account! \n Your balance is $" + Math.Round(customer.eBalance, 2);
                        
                    }
                    else
                    {
                        customer.eBalance = account.Balance;
                        label5.Text = "New Balance is $" + Math.Round(customer.eBalance, 2);
                    }
                    */
                }
                //Investment account withdrawals
                if(selectedAccountType == 1)
                {
                    EverydayAccount account = new InvestmentAccount(value, balance, selectedTransactionType);
                    if(account.failed == true)
                    {
                        customer.iBalance = customer.iBalance - InvestmentAccount.failedFee;
                        label5.Text = "You have insufficient funds in your account \n You have inccured a $10.00 fee \n Your account balance is now $" + Math.Round(customer.iBalance, 2);
                    }
                    else
                    {
                        customer.iBalance = account.Balance;
                        label5.Text = "New Balance is $" + Math.Round(customer.iBalance, 2);
                    }
                }

                //Omni account withdrawals
                if(selectedAccountType == 2)
                {
                    EverydayAccount account = new OmniAccount(value, balance, selectedTransactionType);
                    if(account.failed == true)
                    {
                        customer.oBalance = customer.oBalance - InvestmentAccount.failedFee;
                        label5.Text = "You have insufficient funds in your account \n You have incurred a $10.00 fee \n Your account balance is now $" + Math.Round(customer.oBalance, 2);
                    }
                    else
                    {
                        customer.oBalance = account.Balance;
                        label5.Text = "New Balance is $" + Math.Round(customer.oBalance, 2);
                    }
                }
            }
        }
        //Back Biutton
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.DisplayCustomers();
            form3.Show();
            this.Hide();
            
        }
    }
}
