using System;
using System.Windows.Forms;

namespace Agenda_3cx
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Senha senha = new Senha();
            senha.ShowDialog();
            if (senha.logado)
            {
                Application.Run(new Agenda());
            }
        }
    }
}
