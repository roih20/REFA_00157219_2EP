using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.Equals(textBox2.Text))
            {
                Usuario user= (Usuario) comboBox1.SelectedItem;
                MessageBox.Show("Bienvenido");
                frmAdministrador ventana= new frmAdministrador(user);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
               

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            frmContraseña ventana1 = new frmContraseña();
            ventana1.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            frmRegistro ventana = new frmRegistro();
            ventana.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        public void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "password";
            comboBox1.DisplayMember = "username";
            comboBox1.DataSource = UsuarioBD.UserList();
        }
    }
}
    