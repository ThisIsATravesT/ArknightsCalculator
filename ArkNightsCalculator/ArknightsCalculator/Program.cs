using ArknightsCalculator.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ArknightsCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("PRTS Initializing...");
            Console.WriteLine("Welcome to Rhodes Island Doctor");
            Console.WriteLine();

            // wait
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
