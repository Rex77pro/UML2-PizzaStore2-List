using System;
using System.Collections.Generic;
using System.Text;

namespace UML2_PizzaStore2_List
{
    public static class MenuCataLog
    {
        private static List<Pizza> pizzas = new List<Pizza>() 
        {
            new Pizza("Margaita", 55),
            new Pizza("Pepperoni", 60),
            new Pizza("Hawaii", 65),
            new Pizza("Salat Pizza", 70),
            new Pizza("Hanolulu", 100)
    };

        #region CRUD
        public static void CreatePizza()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Create a Pizza:");
            string name;
            int price;

            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine();

            try
            {
                Console.WriteLine("Enter Price:");
                price = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("You need to enter a valid price for the pizza");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }

            pizzas.Add(new Pizza(name, price));
        }

       public static void ReadPizza()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Read Pizza:");

            try
            {
                int searchNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"You wish to read  pizza: {searchNumber}");
                Console.WriteLine(pizzas[searchNumber]);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("You have entered an invalid value for read");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine();
                Console.WriteLine("The value you want to read does not exist");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void UpdatePizza()
        {

            Console.WriteLine("\n");
            Console.WriteLine($"Update Pizza:");

            Console.WriteLine("Enter a pizza number for the pizza you wish to update:");
            int indexUpdateInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter a new name for pizza:");
            string newName = Console.ReadLine();
            Console.WriteLine();

            int newPrice;

            try
            {
                Console.WriteLine("Enter a new price for pizza:");
                newPrice = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("You need to enter a valid price for the pizza");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }
            

            Console.WriteLine();
            try
            {
                if (pizzas.Contains(pizzas[indexUpdateInput]))
                {
                    pizzas[indexUpdateInput] = new Pizza(newName, newPrice);
                }
                Console.WriteLine($"Pizza has been updated to: {pizzas[indexUpdateInput]}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine();
                Console.WriteLine($"There is no existing pizza with number the {indexUpdateInput}");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }
            
            Console.ReadKey();
        }
        
        public static void DeletePizza()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Delete Pizza:");
            Console.WriteLine();

            int num = Int32.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(pizzas[num]);
                pizzas.Remove(pizzas[num]);
                Console.WriteLine($"Pizza {num} has been deleted:");
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("You have entered an invalid value for delete pizza:");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine();
                Console.WriteLine("The value you have searched for does not exist");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return;
            }

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        #endregion

        public static void PrintMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"View Menu Catalog");
            Console.WriteLine("View Menu:");
            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"Pizza number: {i}, Pizza Name: {pizzas[i].PizzaName} Pizza Price: {pizzas[i].PizzaPrice}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}   
