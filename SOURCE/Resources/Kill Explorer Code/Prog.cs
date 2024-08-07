using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillExplorer
{
    public class Prog
    {
        public static void Main()
        {
            ProcessStartInfo killEx = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = "/c taskkill /f /im explorer.exe",
            };
            Process.Start(killEx);
        }
    }
}
