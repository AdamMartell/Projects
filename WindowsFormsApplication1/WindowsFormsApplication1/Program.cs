using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionHandler test = new ConnectionHandler();
            test.OpenConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Parallel.Invoke(Run, test.Receive);
        }
        public static void Run()
        {
            Application.Run(new Form1());
        }
    }
}
