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
    public partial class GestLibros : UserControl
    {
        public Biblioteca Biblioteca { get; set; }
        public GestLibros(Biblioteca biblioteca)
        {
            this.Biblioteca = biblioteca;
            InitializeComponent();
        }

        private void GestLibros_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            AgregarLibro agregarLibro = new AgregarLibro(this.Biblioteca);
            agregarLibro.Show();
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            EditarLibro editarLibro = new EditarLibro(this.Biblioteca);
            editarLibro.Show();
        }
    }
}
