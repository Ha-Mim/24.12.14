using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryApp
{
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.EmployeeName = nameTextBox.Text;
            aSalary.Basic = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.HouseRentPercent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.MedicalAllowancePercent = Convert.ToDouble(medicalAllowanceTextBox.Text);

            

            MessageBox.Show(aSalary.EmployeeName + ", Your Salary is " + aSalary.CalculateSalary() + " Taka.");

        }
    }
}
