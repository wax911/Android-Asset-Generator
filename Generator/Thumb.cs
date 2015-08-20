using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Generator
{
    public static class Thumb
    {
        public static Image ResizeImage(Bitmap originalBitmap, int maxWidth, int maxHeight)
        {
            Image thumbnail = new Bitmap(maxWidth, maxHeight);

            int originalHeight = originalBitmap.Height;
            int originalWidth = originalBitmap.Width;

            using (var graphic = Graphics.FromImage(thumbnail))
            {
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;

                // Figure out the ratio
                double ratioX = maxWidth/(double) originalWidth;
                double ratioY = maxHeight/(double) originalHeight;

                // use whichever multiplier is smaller
                double ratio = ratioX < ratioY ? ratioX : ratioY;

                // now we can get the new height and width
                int newHeight = Convert.ToInt32(originalHeight*ratio);
                int newWidth = Convert.ToInt32(originalWidth*ratio);

                // Now calculate the X,Y position of the upper-left corner 
                // (one of these will always be zero)
                int posX = Convert.ToInt32((maxWidth - (originalWidth*ratio))/2);
                int posY = Convert.ToInt32((maxHeight - (originalHeight*ratio))/2);

                graphic.Clear(Color.Transparent); // white padding
                graphic.DrawImage(originalBitmap, posX, posY, newWidth, newHeight);
            }

            return thumbnail;
        }
    }
}
