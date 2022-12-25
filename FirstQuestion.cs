using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_work_lab
{
    public partial class FirstQuestion : Form
    {
        public int answer;
        public FirstQuestion()
        {
            InitializeComponent();
        }


        private void button_firstQuestion_answer_Click(object sender, EventArgs e)
        {
            if (answer == 1)
            {
                SecondQuestion newForm = new SecondQuestion();
                newForm.Show();
                this.Hide();
            }
            else 
            {
                TheThirdQuestion newForm = new TheThirdQuestion();
                newForm.Show();
                this.Hide();

            }
        }

        private void radioButton_firstQuestion_yes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                answer = 1;
            }
        }

        private void radioButton_firstQuestion_no_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                answer = 2;
            }
        }
    }
}
