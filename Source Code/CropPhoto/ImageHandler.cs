using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropPhoto
{
    public static class ImageHandler
    {
        public static bool IsValidImage(string filePath)
        {
            try
            {
                using (Image newImage = Image.FromFile(filePath))
                { }
            }
            catch (OutOfMemoryException ex)
            {
                return false;
            }
            return true;
        }
    }
}
