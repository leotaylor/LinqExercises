using System;
using System.Collections.Generic;
using System.Linq;

namespace lingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // var LFruits = fruits.Where(fruit => fruit.StartsWith("L"));

            var LFruits = from fruit in fruits
                          where fruit[0] == 'L'
                          select fruit;

            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();
        }
    }
}
