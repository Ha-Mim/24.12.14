using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultApp
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Result result1 = new Result(Convert.ToDouble(physicsTextBox.Text),Convert.ToDouble(chemistryTextBox.Text),Convert.ToDouble(mathTextBox.Text));
            averageTextBox.Text = result1.GetAverage().ToString();
            gradeTextBox.Text = result1.GetGrade();
        }
    }
}
