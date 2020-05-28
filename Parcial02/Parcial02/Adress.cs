using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Adress : UserControl
    {
        public Adress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("campos vacios");
                
            }
            else
            {
                try
                {
                    string accion = String.Format( "INSERT INTO ADDRESS (idAddres, addres)" + $" VALUES ( {1}, '{textBox1}' ");
                
                    Conexion.Accion(accion);

                    MessageBox.Show("Se agrego la direccion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error");
                }
                
            }
        }
    }
}