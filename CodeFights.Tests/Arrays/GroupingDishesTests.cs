using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFights.Tests.Arrays
{
    [TestClass]
    public class GroupingDishesTests
    {
        [TestMethod]
        public void Test_GroupingDishes_IsValid()
        {
            string[][] dishes = new string[4][];
            dishes[0] = new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" };
            dishes[1] = new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" };
            dishes[2] = new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" };
            dishes[3] = new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" };

            var result = GroupingDishes(dishes);
        }

        static string[][] GroupingDishes(string[][] dishes)
        {
            // Store off each ingredient and their associated dish
            SortedDictionary<string, List<string>> lookup = new SortedDictionary<string, List<string>>();

            // Find the dish, then add each ingredient to the dictionary, associating 
            // the dishes to their ingredient
            for (int index = 0; index < dishes.Length; index++)
            {
                string currentDish = dishes[index][0];
                string[] ingredients = dishes[index];

                for (int innerIndex = 1; innerIndex < ingredients.Length; innerIndex++)
                {
                    // Try to add each ingredient to the Dictionary
                    string currentIngredient = ingredients[innerIndex];
                    if (!lookup.ContainsKey(currentIngredient))
                    {
                        lookup.Add(currentIngredient, new List<string> { currentDish });
                    }
                    else
                    {
                        lookup[currentIngredient].Add(currentDish);
                    }
                }
            }

            var sharedIngredients = lookup.Where(k => k.Value.Count >= 2).ToList();

            string[][] finalDishes = new string[sharedIngredients.Count][];

            int current = 0;
            foreach (var item in sharedIngredients)
            {
                List<string> finalIngredients = new List<string>();
                finalIngredients.Add(item.Key);
                finalIngredients.AddRange(item.Value.OrderBy(i => i));
                finalDishes[current] = finalIngredients.ToArray();
                current++;
            }

            return finalDishes;
        }
    }
}
