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
    public partial class GestUsuarios : UserControl
    {
        public Biblioteca Biblioteca { get; set; } // Propiedad para almacenar la biblioteca

        public GestUsuarios(Biblioteca biblioteca)
        {
            this.Biblioteca = biblioteca;
            InitializeComponent();
        }

        private void GestUsuarios_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnOpAgregarU_Click(object sender, EventArgs e)
        {
            AgregarUsuario0cs agregar = new AgregarUsuario0cs(this.Biblioteca);
            agregar.Show();
        }

        private void btnMostrarU_Click(object sender, EventArgs e)
        {

        }

        private void GestUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
