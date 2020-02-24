using System;
using System.Windows.Forms;

namespace SSASAnalyser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model model = new Model();
            QueryModel queryModel = new QueryModel();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(model, queryModel));
        }
    }
}