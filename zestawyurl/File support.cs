using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zestawyurl
{
    class File_support
    {
        public StreamWriter sw;
        public void CreateAFile(string Path_file)
        {
            string path = $"{Path_file}";
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik został utworzony!");
            }else sw = new StreamWriter(path, true);
        }
            


    }
}
