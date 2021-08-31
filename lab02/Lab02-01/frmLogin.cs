using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Usuario
{
    public string User { get; set; }
    public string Password { get; set; }
    public Usuario(string usuario, string password)
    {
        User = usuario;
        Password = password;
    }
    // Other properties, methods, events...
}

namespace Lab02_01
{
    public partial class frmLogin : Form
    {

        private Usuario[] usuarios = { new Usuario("user1","pass1"), new Usuario("user2", "pass2") };

        private Boolean validarPassword(string usuario, string pass) {
            for (int i = 0; i<usuarios.Length; i++) {
                Usuario user = usuarios[i];
                if (user.User == usuario && user.Password == pass) {
                    return true;
                }
            }
            return false;    
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String user = txtUsuario.Text;
            String pass = txtPassword.Text;
            if (validarPassword(user, pass)) { 
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
