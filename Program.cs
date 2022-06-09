using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitSalad = new List<string>();

            fruitSalad.Add("yogurt");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the ingredient {i + 1}:");
                string userIngredient = Console.ReadLine();
                fruitSalad.Add(userIngredient);
            }

            Console.WriteLine($"Your salad consists of: {fruitSalad.Count} ingredients.");

            DisplayIngredients(fruitSalad);

        }

        public static void DisplayIngredients(List<string> someList)
        {
            foreach (string ingredient in someList)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
