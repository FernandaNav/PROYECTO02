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
    public partial class EliminarLibro : Form
    {
        private Biblioteca biblioteca;
        private Libro libroActual;
        public EliminarLibro(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            btnEliminar.Visible = false;
            dataGridViewLibros.DataSource = biblioteca.ObtenerLibros();
            dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string isbnBuscado = txtIsbnBuscar.Text;
            libroActual = biblioteca.BuscarLibroPorISBN(isbnBuscado);

            if (libroActual != null)
            {
                MessageBox.Show("Libro encontrado, puede proceder a eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Visible = true; 
            }
            else
            {
                MessageBox.Show("Libro no encontrado. Por favor, verifica el ISBN ingresado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsbnBuscar.Text = string.Empty;
                btnEliminar.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (libroActual == null)
            {
                MessageBox.Show("Por favor, busque un libro antes de eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el libro con ISBN '{libroActual.ISBN}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    biblioteca.EliminarLibro(libroActual.ISBN);
                    MessageBox.Show("Libro eliminado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewLibros.DataSource = null;
                    dataGridViewLibros.DataSource = biblioteca.ObtenerLibros();
                    dataGridViewLibros.Columns["Disponible"].ReadOnly = true;
                    btnEliminar.Visible = false;
                    txtIsbnBuscar.Text = string.Empty;
                    libroActual = null; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarLibro_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void EliminarLibro_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
