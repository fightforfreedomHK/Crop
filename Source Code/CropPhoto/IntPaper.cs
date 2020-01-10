using System;
using System.Drawing;

namespace CropPhoto
{
    //International Paper
    public static class IntPaper
    {
        public enum Direction
        {
            Portrait,
            Landscape
        }

        public enum Dimension
        {
            A3, //A3 size (width x height = 297mm x 420mm)
            A4 //A4 size (width x height = 210mm x 297mm)
        }

        public static Size GetSize(Dimension d)
        {
            switch (d)
            {
                case Dimension.A3:
                    return new Size(297, 420);
                case Dimension.A4:
                    return new Size(210, 297);
            }
            return new Size(0, 0);
        }

        //Resize an image's size to A3 or A4 ratio in portrait with keeping the original image ratio
        public static Size Resize(Size imageSize, Dimension dimension, Direction direction)
        {
            Size size = new Size();
            switch (direction)
            {
                case Direction.Portrait:
                    size = calByPortrait(imageSize, dimension);
                    break;
                case Direction.Landscape:
                    size = calByLandscape(imageSize, dimension);
                    break;
            }
            return size;
        }

        private static Size calByPortrait(Size imageSize, Dimension dimension)
        {
            Size ratioSize = GetSize(dimension);
            float ratioWidth = (float)imageSize.Width / ratioSize.Width;
            float ratioHeight = (float)imageSize.Height / ratioSize.Height;
            if (ratioHeight > ratioWidth)
            {
                //Increse the width of photo
                int newWidth = (int)Math.Round(ratioHeight * ratioSize.Width);
                return new Size(newWidth, imageSize.Height);
            }
            else
            {
                //Increase the height of photo
                int newHeight = (int)Math.Round(ratioWidth * ratioSize.Height);
                return new Size(imageSize.Width, newHeight);
            }
        }

        //Resize an image's size to A3 or A4 ratio in landscape with keeping the original image ratio
        private static Size calByLandscape(Size imageSize, Dimension dimension)
        {
            Size ratioSize = GetSize(dimension);
            float ratioWidth = (float)imageSize.Width / ratioSize.Height;
            float ratioHeight = (float)imageSize.Height / ratioSize.Width;
            if (ratioHeight > ratioWidth)
            {
                //Increse the width of photo
                int newWidth = (int)Math.Round(ratioHeight * ratioSize.Height);
                return new Size(newWidth, imageSize.Height);
            }
            else
            {
                //Increase the height of photo
                int newHeight = (int)Math.Round(ratioWidth * ratioSize.Width);
                return new Size(imageSize.Width, newHeight);
            }
        }
    }
}
