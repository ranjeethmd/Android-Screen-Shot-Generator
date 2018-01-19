using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ScreenShotGenerator
{
    class AdbWrapper
    {
        private readonly string _path;
        
        public AdbWrapper()
        {
            _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _path = Path.Combine(_path, "adb.exe");


        }

        public string Command(string command)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName =_path,
                    Arguments = command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();

            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();

            return output;
        }
    }
}
