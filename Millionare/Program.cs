using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainModel mainModel = new MainModel();
                MainWindowForm mainWindow = new MainWindowForm(mainModel);
                MainWindowPresenter windowPresenter = new MainWindowPresenter(mainWindow, mainModel);
                Application.Run(mainWindow);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
