using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
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

            Application.Run(new FormWelcome());
            //Application.Run(new FormPlayBoard());
            // Application.Run(new Formload());
            // Application.Run(new FormLoadGame());
         //   Application.Run(new FormPlayboard3InArow());
        }
    }
}
