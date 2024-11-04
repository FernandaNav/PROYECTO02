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
        private Biblioteca biblioteca; //RECORDAR SIEMPRE INICIALIZAR LA BIBLIOTECA

        public Menu(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            slidePanel.Height = btnHome.Height;
            inicioB2.BringToFront();
            label4.Text = $"        {biblioteca.UsuarioAutenticado.Nombre}";
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
            //Crea la instancia de GestUsuarios y asigna la biblioteca
            gestUsuarios.Biblioteca = biblioteca; //Aquí paso la biblioteca

            this.Controls.Add(gestUsuarios); //Se agrega el control al formulario
            gestUsuarios.BringToFront();
            gestUsuarios.Location = new System.Drawing.Point(265, 68);
        }

        private void gestUsuarios1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inicioB2_Load(object sender, EventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnLibros.Height;
            slidePanel.Top = btnLibros.Top;
            GestLibros gestLibros = new GestLibros(this.biblioteca);
            gestLibros.Biblioteca = biblioteca;
            this.Controls.Add(gestLibros);
            gestLibros.BringToFront();
            gestLibros.Location = new System.Drawing.Point(265, 68);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnInformes.Height;
            slidePanel.Top = btnInformes.Top;
            GenerarInformes generarInformes = new GenerarInformes(this.biblioteca);
            generarInformes.Biblioteca = biblioteca;
            this.Controls.Add(generarInformes);
            generarInformes.BringToFront();
            generarInformes.Location = new System.Drawing.Point(265, 68);
        }
        public void CerrarSesion()
        {
            logOut_Click(null, null);


        }
    }
}
