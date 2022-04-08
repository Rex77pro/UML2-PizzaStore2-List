using System;
using System.Collections.Generic;
using System.Text;


namespace UML2_PizzaStore2_List
{
    class Store
    {
        public void Start()
        {
            Test();
        }

        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("---------------");
            Console.WriteLine("| Pizza Store |");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (String choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }

        public void Test()
        {
            bool proceed = true;
            List<string> mainMenuList = new List<string>()
            {
                "0. Quit",
                "1. Create Pizza",
                "2. Read Pizza",
                "3. Update Pizza",
                "4. Delete Pizza",
                "5. View Menu Catalog"
            };

            Console.WriteLine();
            while(proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenuList);

                switch (MenuChoice)
                {
                    case 0:

                        proceed = false;
                        break;

                    case 1:
                        MenuCataLog.CreatePizza();
                        break;

                    case 2:
                        MenuCataLog.ReadPizza();
                        break;

                    case 3:
                        MenuCataLog.UpdatePizza();
                        break;

                    case 4:
                        MenuCataLog.DeletePizza();
                        break;

                    case 5:
                        MenuCataLog.PrintMenu();
                        break;

                    default:
                        break;
                }
                
            }
        }
        
    }
}
