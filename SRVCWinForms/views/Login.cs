using SRVCWebApi.Modelos;
using SRVCWinForms.source.Inteface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRVCWinForms.views
{
    public partial class Login : Form
    {
        private readonly IUsuarioService _usuarioService;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Login(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPassKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string usu = txtUsu.Text;
            string pass = txtPass.Text;

            Usuario usuario = new Usuario
            {
                Nombre = usu,
                Password = pass
            };

            Usuario usuario1 = await _usuarioService.Login(usuario);
            if (usuario1 != null)
            {
                MessageBox.Show("Inicio de Sesión exitoso.");
                //Form form = new Main(usuario1.Tipo.ToString());
                //form.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
            }
        }

        private void btnCierra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
