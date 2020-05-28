using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Addnegocio : UserControl
    {
        public Addnegocio()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals(""))
            {
                MessageBox.Show("Complete los datos");
            }
            else
            {
                try
                {
                    Conexion.Accion($"INSERT INTO BUSINESS(name, description) VALUES("+
                                    $"'{textBox1.Text}'," +
                                    $"'{textBox2.Text}' )");

                    MessageBox.Show("Se ha agregado el negocio");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha courrido un error");
                }
            }
        }
    }
}