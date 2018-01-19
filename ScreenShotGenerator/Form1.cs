using System;
using System.IO;
using System.Windows.Forms;
using   System.Drawing;

namespace ScreenShotGenerator
{
    public partial class Form1 : Form
    {

        private readonly string _tempPath ;
        
        public Form1()
        {
            InitializeComponent();
            _tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(_tempPath);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void LoadDevices()
        {
            if (deviceCombo.Items.Count > 0)
            {
                deviceCombo.DataSource = null;
                deviceCombo.Items.Clear();
            }
           
            var adbWrapper = new AdbWrapper();
            var formatter = new AdbResponseFormatter(adbWrapper);

            var devices = formatter.GetDevices();

            deviceCombo.DataSource = devices;
        }


        private void screenCaptureBtn_Click(object sender, EventArgs e)
        {
            if (deviceCombo.SelectedItem == null)
            {
                MessageBox.Show("No device selected", "No Device", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            var adbWrapper = new AdbWrapper();
            var formatter = new AdbResponseFormatter(adbWrapper);

            try
            {
                var image = new ImageWrapper(formatter.CaptureImage(_tempPath, (Device) deviceCombo.SelectedItem));
                deviceImagePotrait.Visible = true;
                deviceImagePotrait.Image = image.Image;
                deviceImagePotrait.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                LoadDevices();

                MessageBox.Show("Snap, Something went wrong. Check if the device is still connected ?", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(_tempPath, "output.png")))
            {
                MessageBox.Show("No picture captured to be save.", "Missing Snapshot", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                {
                    File.Delete(saveFileDialog.FileName);
                }
                File.Move(Path.Combine(_tempPath,"output.png"),saveFileDialog.FileName);

                MessageBox.Show("Image saved.", "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deviceRefresh_Click(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void copyToClipboard_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel2.Width, panel2.Height); 
            panel2.DrawToBitmap(bmp,panel2.ClientRectangle);

            Clipboard.SetImage(bmp);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Directory.Delete(_tempPath,true);
            }
            catch
            { }
        }
    }
}
