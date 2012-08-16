
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System.Drawing;
using System.Drawing.Drawing2D;


namespace PuzzleProject
{
    class ImageContro
    {
        private static int nRows;
        private static int  nCols;
        public ImageContro(int rows,int cols)
        {
            nCols = cols;
            nRows = rows;
        }

        public static Image Crop(Image img, Rectangle rect)
        {
            rect.Width = Form1.scrSize / nRows;
            rect.Height = Form1.scrSize / nCols;
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
