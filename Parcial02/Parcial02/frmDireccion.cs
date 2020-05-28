using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmDireccion : Form
    {

        private UserControl current2 = null;
        public frmDireccion()
        {
            InitializeComponent();
            current2 = adress1;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current2);
            current2 =  new Adress();
            tableLayoutPanel1.Controls.Add(current2, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current2, 2);
            
        }
    }
}