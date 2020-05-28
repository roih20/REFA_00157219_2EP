using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals(""))
            {
                MessageBox.Show("Complete los datos");
            }
            else
            {
                try
                {
                    Conexion.Accion($"INSERT INTO APPUSER(fullname, username, password, userType) VALUES("+
                                  $"'{textBox1.Text}', " +
                                  $"'{textBox2.Text}', " +
                                  $"'{textBox3.Text}'," +
                                  $"{true})");

                    MessageBox.Show("Se ha registrado el usuario como administrador ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals(""))
            {
                MessageBox.Show("Complete los datos");
            }
            else
            {
                try
                {
                    Conexion.Accion($"INSERT INTO APPUSER(fullname, username, password, userType) VALUES("+
                                    $"'{textBox1.Text}', " +
                                    $"'{textBox2.Text}', " +
                                    $"'{textBox3.Text}'," +
                                    $"{false})");

                    MessageBox.Show("Se ha registrado el usuario como usuario ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}