using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_northwind
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.DarkGray;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.DarkGray;
            txtUsuario.GotFocus += txtUsuario_GotFocus;
            txtUsuario.LostFocus += txtUsuario_LostFocus;
            txtContraseña.GotFocus += txtContraseña_GotFocus;
            txtContraseña.LostFocus += txtContraseña_LostFocus;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarContraseña.Checked == true)
            {
                txtContraseña.PasswordChar = '\0'; 
            }
            else
            {
                txtContraseña.PasswordChar = '•';   
            }
        }

        private void txtUsuario_GotFocus(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_LostFocus(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContraseña_GotFocus(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.PasswordChar = '•';  
            }
        }

        private void txtContraseña_LostFocus(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = '\0';  
                txtContraseña.ForeColor = Color.DarkGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                string nombre = txtUsuario.Text;
                MessageBox.Show("Bienvenido al sistema!. señor/a: " + nombre, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashscreen splashscreen = new splashscreen();
                this.Hide();
                splashscreen.Show();
                
            }
        }

        private bool Validar()
        {
            bool valid = true;
            if (txtUsuario.Text.Trim() == "Usuario")
            {
                errorProvider1.SetError(txtUsuario, "Es requerido un usuario.");
                valid = false;
            }

            if (txtContraseña.Text.Trim() == "Contraseña")
            {
                errorProvider1.SetError(txtContraseña, "Es requerido una contraseña.");
                valid = false;
            }
            return valid;
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsuario, "");
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtContraseña, "");
        }
    }
}
