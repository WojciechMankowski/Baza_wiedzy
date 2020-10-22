using System;
using System.Collections.Generic;
using System.Text;

namespace zestawyurl
{
    class UserIService
    {
        public string[] category = new string[2];
        public string[] UserAdd()
        {
            Console.WriteLine("Doddanie kategori");
            FileService fileService = new FileService();
            string cat = Console.ReadLine();
            Console.WriteLine("Czy chcesz dodać drugą kategorię? T/N");
            string choice = Console.ReadLine();
            if (choice == "Tak" || choice == "T")
            {
                Console.WriteLine("Doddanie kategori");
                string cat2 = Console.ReadLine();
                Console.WriteLine("Doddanie url");
                var url = Console.ReadLine();
                
                fileService.Checking(cat, cat2);
                category[0] = cat;
                category[1] = cat2;
                //item.Category = cat;
                //Items.Add(item);
                Console.WriteLine($"Dodałeść takie informacje: {cat}, {cat2}, {url}");
            }
            else
            {
                fileService.Checking(cat);
                Console.WriteLine("Doddanie url");
                var url = Console.ReadLine(); 
                Console.WriteLine($"Dodałeść takie informacje: {cat}, {url}");
            }
            
            
            return category;
        }
    }
}
