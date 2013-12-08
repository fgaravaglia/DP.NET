using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StructuralPatterns.Flyweight
{
    public interface IFlyweight
    {
        void Load(string filename);
        void Display(PaintEventArgs e, int row, int col);
    }

    public struct Flyweight : IFlyweight
    {
        // Intrinsic state
        Image pThumbnail;

        private bool ThumbnailCallback()
        {
            return false;
        }

        public void Load(string filename)
        {
            Bitmap currentImage = new Bitmap("images/" + filename);
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            pThumbnail = currentImage.GetThumbnailImage(100, 100, myCallback, new IntPtr());
        }

        public void Display(PaintEventArgs e, int row, int col)
        {
            e.Graphics.DrawImage(pThumbnail, col * 100 + 10, row * 130 + 40,
            pThumbnail.Width, pThumbnail.Height);
        }
    }

}
