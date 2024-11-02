using System;
using System.Windows.Forms;

namespace PROYECTO02
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Crear una única instancia de Biblioteca
            Biblioteca biblioteca = new Biblioteca();

            //Pasar la instancia a Form1 para ir guardando la info
            Application.Run(new Form1(biblioteca));
        }
    }
}
