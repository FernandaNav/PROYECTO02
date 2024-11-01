using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO02
{
    public partial class Menu : Form
    {
        private Biblioteca biblioteca;

        public Menu(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            slidePanel.Height = btnHome.Height;
            inicioB2.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1(biblioteca);
            formLogin.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            slidePanel.Top = btnHome.Top;
            inicioB2.BringToFront();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnUsuarios.Height;
            slidePanel.Top = btnUsuarios.Top;
            GestUsuarios gestUsuarios = new GestUsuarios(this.biblioteca);
            gestUsuarios2.BringToFront();

            // Crear la instancia de GestUsuarios y asignar la biblioteca
            gestUsuarios.Biblioteca = biblioteca; // Aquí pasas la biblioteca

            this.Controls.Add(gestUsuarios); // Asegúrate de agregar el control a tu formulario
        }

        private void gestUsuarios1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
