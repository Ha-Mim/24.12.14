using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountUI : Form
    {
        public AccountUI()
        {
            InitializeComponent();
        }

        
        Account amount1 = new Account();
        private double amount = 0;
        

        private void createButton_Click(object sender, EventArgs e)
        {
             amount1.AccountNo = accountNoTextBox.Text;
             amount1.Name = nameTextBox.Text;
            MessageBox.Show("Account has been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           
            amount = Convert.ToDouble(amountTextBox.Text);
            amount1.Deposit(amount);
            MessageBox.Show("Deposited");

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            amount1.Withdraw(amount);
            MessageBox.Show("Withdrawn");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show( amount1.Name+", Your Account No. is "+amount1.AccountNo+ "and it's Balance is " +amount1.Balance+ " Taka.");
        }
      
    }
}
