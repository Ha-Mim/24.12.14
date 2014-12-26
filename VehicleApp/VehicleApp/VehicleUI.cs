using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        private Vehicle vehicle1 = new Vehicle();

        private void createButton_Click(object sender, EventArgs e)
        {
            vehicle1.Name = nameTextBox.Text;
            vehicle1.RegNo = regNoTextBox.Text;
            MessageBox.Show("Vehicle profile has been created.");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty && regNoTextBox.Text != string.Empty)
            {
                vehicle1.Speed = Convert.ToDouble(speedTextBox.Text);
            }
            else
            {
                MessageBox.Show("Vehicle has not been created.");
            }
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = vehicle1.GetMinSpeed().ToString();
            maxSpeedTextBox.Text = vehicle1.GetMaxSpeed().ToString();
            averageSpeedTextBox.Text = vehicle1.GetAverageSpeed().ToString();
            vehicle1.Max = Convert.ToDouble(maxSpeedTextBox.Text);
            vehicle1.Min = Convert.ToDouble(minSpeedTextBox.Text);
            
        }
    }
}