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
    public partial class AgregarLibro : Form
    {
        private Biblioteca biblioteca;
        public AgregarLibro(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            dataGridViewLibros.DataSource = biblioteca.ObtenerLibros();
            dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
            if (dataGridViewLibros.Columns["Solicitudes"] != null)
            {
                dataGridViewLibros.Columns["Solicitudes"].Visible = false;
            }
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 77, 73);
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            dataGridViewLibros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 178, 170);
            dataGridViewLibros.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewLibros.EnableHeadersVisualStyles = false;
        }

        private void AgregarLibro_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIsbn.Text = string.Empty;
            txtGenero.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtTitulo.Text = string.Empty;
        }
        
        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIsbn.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text) || string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de agregar el libro.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string isbn = txtIsbn.Text.Trim();
            if (isbn.Length != 3) 
            {
                MessageBox.Show("El ISBN debe tener 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string genero = txtGenero.Text.Trim();
            Libro nuevoLibro = new Libro(titulo, autor, isbn, genero);
            try
            {
                biblioteca.AgregarLibro(nuevoLibro);
                dataGridViewLibros.DataSource = null;
                dataGridViewLibros.DataSource = biblioteca.ObtenerLibros();
                dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
                MessageBox.Show("Libro agregado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarLibro_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
