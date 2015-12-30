using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwitterBot2
{
    public static class FileMediaGetter
    {
        
        public static string getFileItem(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            Random rand = new Random();
            int randomLineNumber = rand.Next(0, lines.Length);
            string ChosenItem = lines[randomLineNumber];
            return ChosenItem;
        }

        public static string getMedia()
        {
            Random rand = new Random();
            string[] directoryFile = Directory.GetFiles("Images");
            string image = directoryFile[rand.Next(0, directoryFile.Length)];
            return image;
        }

    }
}
