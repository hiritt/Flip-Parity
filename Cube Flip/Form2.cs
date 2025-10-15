using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cube_Flip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            playbutton.Visible = false;
            Opacity = 0;
            form.Show();
        }
    }
}
