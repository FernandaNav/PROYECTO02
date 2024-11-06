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
    public partial class BuscarLibrosLector : UserControl
    {
        public Biblioteca Biblioteca { get; set; }
        public BuscarLibrosLector(Biblioteca biblioteca)
        {
            this.Biblioteca = biblioteca;
            InitializeComponent();
            dataGridViewLibros.Columns.Add("Titulo", "Título");
            dataGridViewLibros.Columns.Add("Autor", "Autor");
            dataGridViewLibros.Columns.Add("ISBN", "ISBN");
            dataGridViewLibros.Columns.Add("Genero", "Género");
            dataGridViewLibros.Columns.Add("Disponible", "Disponible");
            DiseñoDataGridView();
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 77, 73);
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            dataGridViewLibros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 178, 170);
            dataGridViewLibros.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewLibros.EnableHeadersVisualStyles = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBusqueda.Text;
            Biblioteca.MostrarLibrosEncontrados(valorBusqueda, dataGridViewLibros);
            DiseñoDataGridView();
        }
        private void DiseñoDataGridView()
        {
            foreach (DataGridViewColumn column in dataGridViewLibros.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridViewLibros.Columns[0].Width = 125;
            dataGridViewLibros.Columns[1].Width = 110;
            dataGridViewLibros.Columns[2].Width = 70;
            dataGridViewLibros.Columns[3].Width = 100;
            dataGridViewLibros.Columns[4].Width = 100;
            dataGridViewLibros.AllowUserToAddRows = false;
            dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
            if (dataGridViewLibros.Columns["Solicitudes"] != null)
            {
                dataGridViewLibros.Columns["Solicitudes"].Visible = false;
            }
        }

        private void BuscarLibrosLector_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }
    }
}
