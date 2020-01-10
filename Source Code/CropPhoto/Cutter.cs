using System;
using System.Drawing;

namespace CropPhoto
{
    public static class Cutter
    {
        public enum Orientation
        {
            portrait,
            landscape
        }

        public static Bitmap Crop(Image sourceImage, Rectangle cropRect)
        {
            Bitmap croppedImage = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.Clear(Color.White);
                g.DrawImage(sourceImage,
                    new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                    cropRect, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }

        public static Bitmap Crop(Image sourceImage, Rectangle cropRect, Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.landscape:
                    sourceImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
            }

            Bitmap croppedImage = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(sourceImage,
                    new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                    cropRect, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }
    }
}
