using System;
using System.IO;
using ImageMagick;

namespace ImgConverter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var src = @"C:\temp\Images\";
            var dest = @"C:\temp\Output";

            var iu = new ImageUtils(src);
            iu.ConvertToImage(dest);
        }
        
    }
}
