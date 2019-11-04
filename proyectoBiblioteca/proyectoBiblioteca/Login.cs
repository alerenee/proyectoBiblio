using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace proyectoBiblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string username;
        string pass;
        Usuario user = new Usuario();

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            username = txtUsuario.Text;
            pass = txtPass.Text;
            if(user.Login(username, pass))
            {
                MessageBox.Show("Se ha logueado correctamente");
            }
        }
    }
}
