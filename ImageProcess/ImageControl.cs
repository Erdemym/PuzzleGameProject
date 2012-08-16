
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageProcessLibrary
{
    public  class ImageControl
    {
        //private static field
        private static int nLevel;
        private static int scrSize;

       
        //property
        public static int NLevel
        {
            get { return ImageControl.nLevel; }
        }
        public static int ScrSize
        {
            get { return ImageControl.scrSize; }
        }
        

        //constructor
        public ImageControl(int level, int size)
        {
            ImageControl.nLevel = level;
            ImageControl.scrSize = size;
        }
    
        //static methods
        public static Image SplitImage(Image img, Rectangle rect)
        {
            rect.Width = scrSize / nLevel;
            rect.Height = scrSize / nLevel;
            Bitmap bmpOrj = new Bitmap(img);
            Bitmap bmpCrop = bmpOrj.Clone(rect, bmpOrj.PixelFormat);
            return (Image)(bmpCrop);
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            Bitmap b = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            g.Dispose();

            return (Image)b;
        }

    }
}
