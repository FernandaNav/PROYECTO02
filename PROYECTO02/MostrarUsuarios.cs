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
    public partial class MostrarUsuarios : UserControl
    {
        private Biblioteca biblioteca;
        public MostrarUsuarios(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {

        }
        public void CargarUsuarios()
        {
        }

    }
}
