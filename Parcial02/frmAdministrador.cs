using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmAdministrador : Form
    {
        private Usuario _usuario;
        public frmAdministrador(Usuario user)
        {
            InitializeComponent();
            _usuario = user;


        }


        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            label1.Text =
                "Bienvenido " + _usuario.username + " [ " + (_usuario.userType ? "Administrador" : "Usuario") + "]";
            

            if (_usuario.userType)
            {
                ActualizarControles();
            }
            else
            {
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null;
                
                
            }
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            frmNegocio negocio = new frmNegocio();
            negocio.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
       
            frmAdminUser ventana2 = new frmAdminUser();
            ventana2.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            frmProducto producto = new frmProducto();
            producto.Show();
            this.Hide();
        }

        private void ActualizarControles()
        {
            List<Usuario> lista = UsuarioBD.UserList();
            
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            frmDireccion direccion = new frmDireccion();
            direccion.Show();
            this.Hide();
        }
    }
}