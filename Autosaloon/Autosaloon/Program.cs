using System;
using System.Windows.Forms;

namespace Autosaloon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var saloon = new Avtosaloon("MaverickAutos");
            var auto = new Car(saloon);
            auto.Name = "porshe";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(saloon));
        }
    }
}
