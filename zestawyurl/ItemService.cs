using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace zestawyurl
{
    class ItemService
    {
        
        public List<string> listacategory = new List<string>();
        public void AddURL()
        {
            UserIService userIService = new UserIService();
            userIService.UserAdd();
        }
       
    }
}

