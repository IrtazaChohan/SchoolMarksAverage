using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMarksAverage
{
    public partial class FrmSchoolMarksAverage : Form
    {
        public FrmSchoolMarksAverage()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int mark1, mark2, mark3, mark4;
            float average;
            string result;

            mark1 = int.Parse(txtTextbox1.Text);
            mark2 = int.Parse(txtTextbox2.Text);
            mark3 = int.Parse(txtTextbox3.Text);
            mark4 = int.Parse(txtTextbox4.Text);

            average = (float)((mark1 + mark2 + mark3 + mark4) / 4);

            if (average <= 50)
            {
                result = "Sorry you have a failing grade. Your grade is: " + average.ToString();
            }
            else if (average >= 51 && average <= 70)
            {
                result = "Nearly got there. Your grade is: " + average.ToString();
            }
            else
            {
                result = "You have a passing grade. Your grade is: " + average.ToString();
            }

            MessageBox.Show(result);
        }
    }
}
