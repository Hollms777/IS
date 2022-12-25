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
    public partial class End_no : Form
    {
        public End_no()
        {
            InitializeComponent();
        }

        private void button_end_no_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
