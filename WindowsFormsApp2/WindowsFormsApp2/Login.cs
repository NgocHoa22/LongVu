using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "You want to ESC",
              "confirm",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
              );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == txtcf.Text)
            {
                Form1 from1 = new Form1();
                from1.Show();
                this.Hide();
            }
        }
    }
}
