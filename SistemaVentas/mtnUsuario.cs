using CapaDatos;
using CapaModelo;
using SistemaVentas.Reutilizable;
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
    public partial class mtnUsuario : Form
    {
        private bool modoEditar = false;
        public mtnUsuario(Usuario pUsuario = null)
        {
            InitializeComponent();

            cboActivo.Enabled = false;
            LoadComboSelect();

            if (pUsuario == null) return;

            modoEditar = true;
            cboActivo.Enabled = true;
            txtIdUsuario.Text = pUsuario.IdUsuario.ToString();
            txtNombres.Text = pUsuario.Nombres;
            txtApellidos.Text = pUsuario.Apellidos;
            txtCorreo.Text = pUsuario.Correo;
            txtUsuario.Text = pUsuario.NombreUsuario;
            txtClave.Text = pUsuario.Clave;

            SetComboBoxSelectedIndex(cboTienda, pUsuario.IdTienda);
            SetComboBoxSelectedIndex(cboRol, pUsuario.IdRol);
            SetComboBoxSelectedIndex(cboActivo, pUsuario.Activo);
        }
        private void SetComboBoxSelectedIndex(ComboBox comboBox, object value)
        {
            foreach (ComboBoxItem item in comboBox.Items)
            {
                if (!item.Value.Equals(value)) continue;

                comboBox.SelectedIndex = comboBox.Items.IndexOf(item);
                break;
            }
        }

        private void LoadComboSelect(){
            AddItemsToComboBox(cboActivo, new List<ComboBoxItem>
            {
                new ComboBoxItem { Value = true, Text = "Si" },
                new ComboBoxItem { Value = false, Text = "No" }
            });

            AddItemsToComboBox(cboTienda, CdTienda.ObtenerTiendas()
                .Where(x => x.Activo)
                .Select(x => new ComboBoxItem { Value = x.IdTienda, Text = x.Nombre })
                .ToList());

            AddItemsToComboBox(cboRol, CdRol.ObtenerRol()
                .Where(x => x.Activo)
                .Select(x => new ComboBoxItem { Value = x.IdRol, Text = x.Descripcion })
                .ToList());
        }

        private void AddItemsToComboBox(ComboBox comboBox, List<ComboBoxItem> items)
        {
            comboBox.Items.AddRange(items.ToArray());
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            comboBox.SelectedIndex = 0;
        }


        private void mtnUsuario_Load(object sender, EventArgs e)
        {
            txtNombres.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == "" && txtApellidos.Text.Trim() == "" && txtCorreo.Text.Trim() == "" && txtUsuario.Text.Trim() == "" && txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje");
                return;
            }
            

            Usuario oUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32( txtIdUsuario.Text.Trim()),
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                NombreUsuario = txtUsuario.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                IdTienda = Convert.ToInt32(((ComboBoxItem)cboTienda.SelectedItem).Value),
                IdRol = Convert.ToInt32(((ComboBoxItem)cboRol.SelectedItem).Value),
                Activo = Convert.ToBoolean(((ComboBoxItem)cboActivo.SelectedItem).Value)
            };

            bool Respuesta = false;
            string msgSuccess = "";
            string msgError = "";
            if (modoEditar)
            {
                Respuesta = CdUsuario.ModificarUsuario(oUsuario);
                msgSuccess = "Usuario Modificado \n¿Desea registrar un nuevo usuario ahora?";
                msgError = "No se pudo modificar el usuario, \nes posible que ya se encuentre registrado";
            }
            else
            {

                Respuesta = CdUsuario.RegistrarUsuario(oUsuario);
                msgSuccess = "Usuario Registrado \n¿Desea registrar un nuevo usuario ahora?";
                msgError = "No se pudo registrar el usuario, \nes posible que ya se encuentre registrado";

            }

            if (Respuesta)
            {
                if (MessageBox.Show(msgSuccess, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtCorreo.Text = "";
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    cboRol.SelectedIndex = 0;
                    cboTienda.SelectedIndex = 0;

                    foreach (ComboBoxItem item in cboActivo.Items)
                    {
                        if ((bool)item.Value == true)
                        {
                            int index = cboActivo.Items.IndexOf(item);
                            cboActivo.SelectedIndex = index;
                            break;
                        }
                    }

                    cboActivo.Enabled = false;
                    modoEditar = false;
                    txtNombres.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(msgError, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
