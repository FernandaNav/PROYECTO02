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
    public partial class PedirContrasena : Form
    {
        private Biblioteca biblioteca;
        public string Password { get; private set; }
        public PedirContrasena(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
            Password = string.Empty;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Password = txtPassword.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
