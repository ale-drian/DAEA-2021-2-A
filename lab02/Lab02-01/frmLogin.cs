using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


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
        SqlConnection conn;

        // private Usuario[] usuarios = { new Usuario("user1","pass1"), new Usuario("user2", "pass2") };

        public frmLogin()
        {
            conectarBD();
            InitializeComponent();
        }

        private void conectarBD() {
            //Declaracion de variables
            String servidor = "DESKTOP-1HN4GP8\\SQLEXPRESS2017";
            String bd = "db_lab03";
            
            String str = "Server=" + servidor + ";Database=" + bd + ";";
            str += "Integrated Security=true";
            
            try
            {
                conn = new SqlConnection(str);
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }

        private Boolean validarPassword(string usuario, string pass)
        {

            String sql = "SELECT COUNT(*) FROM tbl_usuario WHERE usuario_nombre = @usuario AND usuario_password = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@password", pass);
            int total = (int)cmd.ExecuteScalar();
            if (total >= 1)
                return true;
            return false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String user = txtUsuario.Text;
            String pass = txtPassword.Text;
            if (validarPassword(user, pass))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
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
