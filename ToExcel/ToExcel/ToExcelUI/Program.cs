using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToExcelUI.Views;
using ToExcelUI.Presenters;
using ToExcelUI.Data;

namespace ToExcelUI
{
    static class Program
    {
        public static IViewsController Controller { get; } = new ViewsController();
        public static IRepository Repository { get; } = new EpplusRepository();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(Controller.GetMainForm());
        }
    }
}
