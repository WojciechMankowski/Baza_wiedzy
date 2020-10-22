using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zestawyurl
{
    class FileService
    {
        public void SaveInFile(string category, string categors2 = "")
        {
            File_support file_Support = new File_support();
            file_Support.CreateAFile("Category.txt");
            Console.WriteLine(category);
            Console.WriteLine(categors2);
            file_Support.sw.WriteLine(category);
            file_Support.sw.WriteLine(categors2);
            file_Support.sw.Close();
        }
        public void ReadFile()
        {

            StreamReader sr = File.OpenText("Category.txt");
            Console.WriteLine("\nZAWARTOŚĆ PLIKU");
            string s = "";
            while(( s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            
        }
        public void Checking(string category, string category2="")
        {

            StreamReader sr = File.OpenText("Category.txt");
            Console.WriteLine("\nZAWARTOŚĆ PLIKU");
            string line = "";
            FileService fileService = new FileService();
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                if (line != category)
                {
                    fileService.SaveInFile(category);
                }
                else if (line != category2)
                {
                    fileService.SaveInFile(category2);
                }
            }
            sr.Close();

        }
    }
}
