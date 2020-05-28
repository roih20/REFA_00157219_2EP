using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmAdminUser : Form
    {
        private UserControl current = null;
        public frmAdminUser()
        {
            InitializeComponent();
            current = agregarUser1;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 2);
        }
    }
}