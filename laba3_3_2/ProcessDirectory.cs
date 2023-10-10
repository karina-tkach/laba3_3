using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System.IO;

namespace laba3_3_2
{
    public class ProcessDirectory
    {
        static Regex regexExtForImage = new Regex("^((\\.bmp)|(\\.gif)|(\\.tiff?)|(\\.jpe?g)|(\\.png))$", RegexOptions.IgnoreCase);
        public static void ProcessFiles(string path, string[] data)
        {
            foreach(string  fileName in data)
            {
                string ext = Path.GetExtension(fileName);
                string name = Path.GetFileNameWithoutExtension(fileName);
                
                if (regexExtForImage.IsMatch(ext))
                {
                    string fileSavePath = Path.Combine(path, name + "-mirrored.gif");
                    Bitmap image = new Bitmap(fileName);
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    image.Save(fileSavePath, ImageFormat.Gif);

                }
            }
        }
    }
}
