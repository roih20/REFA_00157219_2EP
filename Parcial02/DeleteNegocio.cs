using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class DeleteNegocio : UserControl
    {
        public DeleteNegocio()
        {
            InitializeComponent();
        }

        private void DeleteNegocio_Load(object sender, EventArgs e)
        {
            var negocio = Conexion.Consulta("SELECT name FROM BUSINESS ");
            var negocioBox = new List<string>();

            foreach (DataRow dr in negocio.Rows)
            {
                negocioBox.Add(dr[0].ToString());
            }

            comboBox1.DataSource = negocioBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
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
                    var idBusiness = Convert.ToInt32(dr[0].ToString());

                    string accion = $"DELETE FROM BUSINESS WHERE idBusiness = {idBusiness}";
                    
                    Conexion.Accion(accion);
                    MessageBox.Show("Se ha eliminado el negocio");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}