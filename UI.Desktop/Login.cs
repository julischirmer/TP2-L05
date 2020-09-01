using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txtContraseña.PasswordChar == '\0')
            {
                txtContraseña.PasswordChar = '*';
            } else
            {
                txtContraseña.PasswordChar = '\0';
            }
            
        }

        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic user = new UsuarioLogic();
            Usuario usuarioActual = new Usuario();
            usuarioActual = user.GetOne(txtUsuario.Text);

            if(usuarioActual is null || (usuarioActual.Clave != txtContraseña.Text))
            {
                lbMensaje.Text = "Usuario no existente o datos incorrectos";
                pError.BackColor = Color.Brown;
                pError.Visible = true;
                lbMensaje.Visible = true;

            } else {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            
            
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            pError.Visible = false;
            lbMensaje.Visible = false;
        }
    }
}
