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

            var filtredFruits = fruits.Where(fruit => fruit.StartsWith("L"));

            foreach (var fruit in filtredFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();
        }
    }
}
