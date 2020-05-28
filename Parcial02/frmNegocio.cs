using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmNegocio : Form
    {

        private UserControl current1 = null;
        public frmNegocio()
        {
            InitializeComponent();
            current1 = addnegocio1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current1);
            current1 = new Addnegocio();
            tableLayoutPanel1.Controls.Add(current1, 0, 1 );
            tableLayoutPanel1.SetColumnSpan(current1, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current1);
            current1 = new DeleteNegocio();
            tableLayoutPanel1.Controls.Add(current1, 0, 1 );
            tableLayoutPanel1.SetColumnSpan(current1, 2);
        }
    }
}