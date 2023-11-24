using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAmAMachine
{
    internal static class Program
    {
        [STAThread] //Attributes
        static void Main()
        {
            //if(Environment.OSVersion.Version.Major >= 6)
                //SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDS());

        }
        [System.Runtime.InteropServices.DllImport("user32.dll")] //Use HDPI via API calls
        private static extern bool SetProcessDPIAware(); //	Windows Vista	
    }
}
