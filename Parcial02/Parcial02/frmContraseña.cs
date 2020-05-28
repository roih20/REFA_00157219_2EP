using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmContraseña : Form
    {
        public frmContraseña()
        {
            InitializeComponent();
        }


        private void frmContraseña_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "password ";
            comboBox1.DisplayMember = "username";
            comboBox1.DataSource = UsuarioBD.UserList();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            bool actualIgual = comboBox1.SelectedValue.Equals(textBox1.Text);
            bool nuevaIgual = textBox2.Text.Equals(textBox3.Text);
            bool nuevaValida = textBox2.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    UsuarioBD.cambiarContra(comboBox1.Text, textBox2.Text);

                    MessageBox.Show("Se ha cambiado la contraseña con exito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                MessageBox.Show("Verifique que sus datos sean correctos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}