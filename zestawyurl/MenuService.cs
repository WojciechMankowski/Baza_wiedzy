using System;
using System.Collections.Generic;
using System.Text;

namespace zestawyurl
{
    class MenuService
    {
        private List<Menu> menuActions;
        public MenuService()
        {
            menuActions = new List<Menu>();
        }

        public void AddNewAction(int id, string name, string menuName)
        {
           Menu menuAction = new Menu() {Id=id, Name=name,  MenuName = menuName };
            menuActions.Add(menuAction);
        }

        public List<Menu> GetMenuActionsByMenuName(string menuName)
        {
            List<Menu> result = new List<Menu>();
            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
    }
}
