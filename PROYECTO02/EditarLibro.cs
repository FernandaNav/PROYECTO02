﻿using System;
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
    public partial class EditarLibro : Form
    {
        private Biblioteca biblioteca;
        private Libro libroActual;
        public EditarLibro(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            panEditar.Visible = false;
            dataGridViewLibros.DataSource = biblioteca.ObtenerLibrosOrdenados();
            DiseñoDataGridView();
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 77, 73);
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            dataGridViewLibros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 178, 170);
            dataGridViewLibros.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewLibros.EnableHeadersVisualStyles = false;
        }

        private void EditarLibro_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string isbnBuscado = txtIsbnBuscar.Text;
            libroActual = biblioteca.BuscarLibroPorISBN(isbnBuscado);
            if (libroActual != null)
            {
                txtGeneroEdit.Text = libroActual.Genero;
                txtAutorEdit.Text  = libroActual.Autor;
                txtTituloEdit.Text = libroActual.Titulo;
                MessageBox.Show("ISBN encontrado, puede editar los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panEditar.Visible = true;

            }
            else
            {
                MessageBox.Show("Libro no encontrado. Por favor, verifica el ISBN ingresado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsbnBuscar.Text = string.Empty;
                LimpiarCampos();
            }
        }

        private void panEditar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LimpiarCampos()
        {
            txtGeneroEdit.Text = string.Empty;
            txtTituloEdit.Text = string.Empty;
            txtAutorEdit.Text = string.Empty;
        }

        private void EditarLibro_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (libroActual == null)
            {
                MessageBox.Show("Por favor, busque un libro antes de editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica que todos los campos requeridos estén llenos
            if (string.IsNullOrWhiteSpace(txtTituloEdit.Text) ||
                string.IsNullOrWhiteSpace(txtAutorEdit.Text) ||
                string.IsNullOrWhiteSpace(txtGeneroEdit.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nuevoTitulo = txtTituloEdit.Text;
            string nuevoAutor = txtAutorEdit.Text;
            string nuevoGenero = txtGeneroEdit.Text;
            string isbn = libroActual.ISBN; 
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea editar el libro con ISBN '{isbn}'?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    biblioteca.EditarLibro(isbn, nuevoTitulo, nuevoAutor, nuevoGenero);
                    MessageBox.Show("Libro actualizado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIsbnBuscar.Text = string.Empty;
                    panEditar.Visible = false;
                    dataGridViewLibros.DataSource = null;
                    dataGridViewLibros.DataSource = biblioteca.ObtenerLibrosOrdenados();
                    DiseñoDataGridView();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
            dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
            if (dataGridViewLibros.Columns["Solicitudes"] != null)
            {
                dataGridViewLibros.Columns["Solicitudes"].Visible = false;
            }
        }
    }
}
