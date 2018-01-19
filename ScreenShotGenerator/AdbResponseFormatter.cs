using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotGenerator
{
    class AdbResponseFormatter
    {
        private readonly AdbWrapper _adb;
        public AdbResponseFormatter(AdbWrapper adb)
        {
            _adb = adb;
        }

        public IList<Device> GetDevices()
        {
            var list = new List<Device>();
            var devices = _adb.Command("devices");
            var splitString = devices.Split('\n');

            if (splitString.Length > 1)
            {
                for (var i = 1; i < splitString.Length; i++)
                {
                    var data = splitString[i];
                    var dataSplit = data.Split('\t');

                    if (dataSplit.Length == 2)
                    {
                        var device = new Device(dataSplit[0].Trim(), dataSplit[1].Trim());
                        list.Add(device);
                    }
                }
            }
            return list;
        }

        public string CaptureImage(string location, Device device)
        {
            var path = Path.Combine(location, "output.png");

            if (File.Exists(path))
            {
                File.Delete(path);
            }


            var captureCommand = $"-s {device.Name} shell screencap -p \"/mnt/sdcard/output.png\"";
            var result = _adb.Command(captureCommand);

            var moveCommand = $"-s {device.Name}  pull -p -a \"/mnt/sdcard/output.png\" \"{path}\"";
            result = _adb.Command(moveCommand);

            var removeCommand = $"shell rm \"/sdcard/screen.png\"";
            result = _adb.Command(removeCommand);

            return path;
        }
    }
}
