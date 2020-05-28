using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AddProducto : UserControl
    {
        public AddProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || (comboBox1.Text.Equals("")))
            {
                MessageBox.Show("Campo vacio");
            }
            else
            {
                try
                {
                    string consulta =
                        $"SELECT idBusiness FROM BUSINESS WHERE name = '{comboBox1.SelectedItem.ToString()}'";
                    var dt = Conexion.Consulta(consulta);
                    var dr = dt.Rows[0];
                    var idBusinnes1 = Convert.ToInt32(dr[0].ToString());
                    
                    MessageBox.Show("Se ha agregado el producto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {

        }
    }
}