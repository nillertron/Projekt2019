using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjektOpgave1Sem2019
{
    //Martin
    class PictureHelper
    {
        static string path = @"c:\users\marti\RealBoligPics";

        static List<Image> images = new List<Image>(); //Contains images from folder
        public static List<Image> Images { get { return images; } set { images = value; } }


        public static void LoadImages() //Loads images into class
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach(FileInfo fi in di.GetFiles())
            {
                //Check om filen er et billede
                if(fi.Extension == ".jpg" || fi.Extension == ".jpeg" || fi.Extension == ".png" || fi.Extension == ".bmp")
                {
                    Image i = Image.FromFile(fi.FullName);
                    i.Tag = fi.Name;
                    images.Add(i);
                }
            }
            Images = images;
        }
    }
}
