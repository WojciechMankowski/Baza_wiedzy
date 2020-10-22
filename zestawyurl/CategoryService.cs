using System;
using System.Collections.Generic;
using System.Text;

namespace zestawyurl
{
    class CategoryService
    {
        

        public void CreatList()
        {
            FileService fileService = new FileService();
            fileService.ReadFile();

        }
    }
}
