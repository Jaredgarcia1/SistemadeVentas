using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int userId = CdUsuario.LoginUsuario(txtUsuario.Text, txtClave.Text);
            if (userId > 0)
            {
                var mdiMasterForm = new MDIMaster(userId);
                mdiMasterForm.Show();
                this.Hide();
                mdiMasterForm.FormClosing += Frm_Closing;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtUsuario.Focus();
            this.Show();
        }
    }
}
