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
    public partial class SecondQuestion : Form
    {
        public int answer;
        public SecondQuestion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Question_answer_Click(object sender, EventArgs e)
        {
            if (answer == 1)
            {
                End_no newForm = new End_no();
                newForm.Show();
                this.Hide();
            }
            else
            {

                End_yes newForm = new End_yes();
                newForm.Show();
                this.Hide();
            }
        }

        private void radioButton_Question_no_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                answer = 1;
            }
        }

        private void radioButton_Question_yes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                answer = 2;
            }
        }
    }
}
