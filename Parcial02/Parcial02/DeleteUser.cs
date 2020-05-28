using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("No deje espacios vacios");
            }
            else
            {
                try
                {
                    string consulta =
                        $"SELECT idUser FROM APPUSER WHERE username = '{comboBox1.SelectedItem.ToString()}'";

                    var dt = Conexion.Consulta(consulta);
                    var dr = dt.Rows[0];
                    var idUser = Convert.ToInt32(dr[0].ToString());

                    string accion = $"DELETE FROM APPUSER WHERE idUser = {idUser}";
                    
                    Conexion.Accion(accion);

                    MessageBox.Show("Se ha eliminado el usuario");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            var nombreusuario = Conexion.Consulta("SELECT username FROM APPUSER");
            var usuarioCmb = new List<string>();

            foreach (DataRow dr in nombreusuario.Rows)
            {
                usuarioCmb.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usuarioCmb;
        }
        
    }
}