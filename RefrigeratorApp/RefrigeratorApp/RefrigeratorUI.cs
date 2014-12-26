using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }
        Refrigerator aRefrigerator = new Refrigerator();
        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.MaxWeight = Convert.ToDouble(maxWeightTextBox.Text);
            MessageBox.Show("Information has been added.");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (maxWeightTextBox.Text != String.Empty)
            {
                    aRefrigerator.NoOfItem = Convert.ToDouble(noOfItemsTextBox.Text);
                    aRefrigerator.ItemWeight = Convert.ToDouble(weightTextBox.Text);
                    if (aRefrigerator.NoOfItem*aRefrigerator.ItemWeight < aRefrigerator.MaxWeight-aRefrigerator.CurrentWeight)
                    {
                    currentWeightTextBox.Text = aRefrigerator.GetCurrentWeight().ToString();
                    remainingWeightTextBox.Text = aRefrigerator.GetRemainingWeight().ToString();
                    aRefrigerator.CurrentWeight = Convert.ToDouble(currentWeightTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Refrigarator is Overloaded.");
                }
            }
            else
            {
                MessageBox.Show("Maximum Weight has not set.");
            }
        }
    }
}
