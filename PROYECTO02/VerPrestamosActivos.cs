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
    public partial class VerPrestamosActivos : Form
    {
        private Biblioteca biblioteca;
        public VerPrestamosActivos(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            dataGridPrestamos.DataSource = biblioteca.ObtenerPrestamosActivos();
            foreach (DataGridViewColumn column in dataGridPrestamos.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridPrestamos.Columns["TituloLibro"].HeaderText = "Título del Libro";
            dataGridPrestamos.Columns["TituloLibro"].Width = 175;
            dataGridPrestamos.Columns["NombreUsuario"].HeaderText = "Usuario";
            dataGridPrestamos.Columns["NombreUsuario"].Width = 150;
            dataGridPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha de Préstamo";
            dataGridPrestamos.Columns["FechaPrestamo"].Width = 175;
            if (dataGridPrestamos.Columns["FechaDevolucion"] != null)
            {
                dataGridPrestamos.Columns["FechaDevolucion"].Visible = false;
            }
            dataGridPrestamos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 77, 73);
            dataGridPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridPrestamos.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            dataGridPrestamos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 178, 170);
            dataGridPrestamos.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridPrestamos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridPrestamos.EnableHeadersVisualStyles = false;
        }

        private void dataGridPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerPrestamosActivos_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void VerPrestamosActivos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
