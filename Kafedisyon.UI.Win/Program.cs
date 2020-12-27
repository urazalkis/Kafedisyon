using Kafedisyon.UI.Win.Forms;
using Kafedisyon.UI.Win.Forms.BaseForms;
using Kafedisyon.UI.Win.Forms.GenelFormlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafedisyon.UI.Win
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}
