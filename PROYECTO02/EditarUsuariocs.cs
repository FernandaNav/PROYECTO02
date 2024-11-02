using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO02
{
    public partial class EditarUsuariocs : Form
    {
        private Biblioteca biblioteca;
        private Usuario usuarioActual;
        public EditarUsuariocs(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            panEditar.Visible = false;
            dataGridViewUsuarios.DataSource = biblioteca.ObtenerUsuarios();
            if (dataGridViewUsuarios.Columns["Contrasena"] != null)
            {
                dataGridViewUsuarios.Columns["Contrasena"].Visible = false;
            }
        }

        private void EditarUsuariocs_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void EditarUsuariocs_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtNombreBuscar.Text;

            //Llamar al método de buscarUsuario para buscar en la biblioteca
            usuarioActual = biblioteca.BuscarUsuario(nombreBuscado);
            if (usuarioActual != null)
            {
                txtNombreEdit.Text = usuarioActual.Nombre; 
                txtPasswordEdit.Text = usuarioActual.Contrasena;
                cmbRolEdit.SelectedItem = usuarioActual.Rol; 
                MessageBox.Show("Usuario encontrado. Puede editar o eliminar los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panEditar.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado. Por favor, verifica el nombre ingresado.", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Por favor, busque un usuario antes de editar.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreEdit.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordEdit.Text) ||
                string.IsNullOrWhiteSpace(cmbRolEdit.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoNombre = txtNombreEdit.Text;
            string nuevaContraseña = txtPasswordEdit.Text;
            string nuevoRol = cmbRolEdit.SelectedItem.ToString();

            DialogResult result = MessageBox.Show($"¿Está seguro de que desea editar al usuario '{usuarioActual.Nombre}'?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    biblioteca.EditarUsuario(usuarioActual.Nombre, nuevoNombre, nuevaContraseña, nuevoRol);
                    usuarioActual.Nombre = nuevoNombre;
                    MessageBox.Show("Usuario actualizado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridView();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtNombreBuscar.Text = string.Empty;
            txtNombreEdit.Text = string.Empty;
            txtPasswordEdit.Text = string.Empty;
            cmbRolEdit.SelectedIndex = -1;
            usuarioActual = null;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            panEditar.Visible = false;
        }
        private void ActualizarDataGridView()
        {
            dataGridViewUsuarios.DataSource = null; 
            dataGridViewUsuarios.DataSource = biblioteca.ObtenerUsuarios();
            if (dataGridViewUsuarios.Columns["Contrasena"] != null)
            {
                dataGridViewUsuarios.Columns["Contrasena"].Visible = false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Por favor, busque un usuario antes de eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario '{usuarioActual.Nombre}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    biblioteca.EliminarUsuario(usuarioActual.Nombre);
                    ActualizarDataGridView();

                    LimpiarCampos(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panEditar_Paint(object sender, PaintEventArgs e)
        {
            BackColor = TransparencyKey;
        }
    }
}
