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
    public partial class MenuLector : Form
    {
        private Biblioteca biblioteca;
        public MenuLector(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
        }

        private void MenuLector_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            slidePanel.Top = btnHome.Top;
            inicioL1.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1(biblioteca);
            formLogin.Show();
            this.Hide();
        }
    }
}
