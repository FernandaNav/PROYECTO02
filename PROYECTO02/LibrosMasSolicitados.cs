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
    public partial class LibrosMasSolicitados : Form
    {
        private Biblioteca biblioteca;
        public LibrosMasSolicitados(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            dataGridViewLibros.DataSource = biblioteca.ObtenerLibrosMasSolicitados();
            foreach (DataGridViewColumn column in dataGridViewLibros.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridViewLibros.Columns[0].Width = 100;
            dataGridViewLibros.Columns[1].Width = 100;
            dataGridViewLibros.Columns[2].Width = 70;
            dataGridViewLibros.Columns[3].Width = 95;
            dataGridViewLibros.Columns[4].Width = 100;
            dataGridViewLibros.Columns[5].Width = 90;
            dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 77, 73);
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Bold);
            dataGridViewLibros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 178, 170);
            dataGridViewLibros.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewLibros.EnableHeadersVisualStyles = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LibrosMasSolicitados_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void LibrosMasSolicitados_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
