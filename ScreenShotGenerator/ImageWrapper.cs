using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotGenerator
{
    class ImageWrapper
    {
        private readonly Image _image;

        public ImageWrapper(string path)
        {
            using (var bmpTemp = new Bitmap(path))
            {
                _image = new Bitmap(bmpTemp);
            }
        }

        public bool IsLandscape
        {
            get
            {
                if(_image.Width > _image.Height)
                    return true;

                return false;
            }
        }

        public Image Image
        {
            get { return _image; }
        }

    }
}
