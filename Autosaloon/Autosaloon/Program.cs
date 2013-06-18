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
            //var saloon = new Avtosaloon("MaverickAutos");
            
            //var auto = new Car(saloon);
            //auto.Name = "porshe";

            //var auto1 = new Car(saloon);
            //auto1.Name = "Toyota";

            //var app1 = new UIApplicationsForDelayedDelivery("Maxik", auto, 20);
            //app1.CellNumber = "8-9053-353242";

            //var app2 = new UIApplicationsForDelayedDelivery("Maxik2", auto, 20);
            //app2.CellNumber = "8-9053-353242";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
