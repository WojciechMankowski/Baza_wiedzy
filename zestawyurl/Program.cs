using System;

namespace zestawyurl
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Dodanie nowego adresu 
            ///najpierw prośba o wpisani pierwszej kategorii oraz drugiej
            ///podanie adresu url
            // 2. Wyświatlenie listy kategori
            /// Wyświetlenie lisy kaegorie
            // 3. Wyświatlenie listy url z danej kategorie
            /// prośba o podanie kategoriee
            /// wyświetlenie listy 
            /// 

            Console.WriteLine("Witam! W naszym programie.");
            Console.WriteLine("Proszę wybież opjcę od której chcesz zarząć.");

            MenuService actionService = new MenuService();
            actionService = Initialize(actionService);
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
            var choice = Console.ReadKey();
            ItemService itemService = new ItemService();
            CategoryService categoryService = new CategoryService();
            switch (choice.KeyChar)
            {
                case '1':
                    itemService.AddURL();
                    break;
                case '2':
                    categoryService.CreatList();
                    break;
                case '3':
                    break;
                default:
                    Console.WriteLine("Błądna wartość");
                    break;
            }
        }

        private static MenuService Initialize(MenuService actionService)
        {
            actionService.AddNewAction(1, "Dodanie URL", "Main");
            actionService.AddNewAction(2, "Wyświaetlenie listy kategorii", "Main");
            actionService.AddNewAction(3, "Wyświetlenie listy URL z danej kategorii", "Main");
            return actionService;
        }

    }
}
