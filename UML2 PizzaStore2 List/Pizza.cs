using System;
using System.Collections.Generic;
using System.Text;

namespace UML2_PizzaStore2_List
{
    public class Pizza
    {   
        public Pizza(string pName, double pPrice)
        {
            PizzaName = pName;
            PizzaPrice = pPrice;
        }

        public string PizzaName { get; set; }
        public double PizzaPrice {get; set; }


        public override string ToString()
        {
            return $"Name: {PizzaName}, Price: {PizzaPrice} DKK";
        }

    }
}
