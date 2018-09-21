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
                          where fruit.StartsWith("L")
                          select fruit;

            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(number => number % 6 == 0 || number % 4 == 0);

            foreach(var number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend = from name in names
                          orderby name descending
                          select name;

            foreach(var name in descend)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            // Build a collection of these numbers sorted in ascending order
            List<int> numeros = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var ascendingNumbers = from numero in numeros
                                   orderby numero ascending
                                   select numero;

            foreach(var numero in ascendingNumbers)
            {
                Console.WriteLine(numero);
            }
            Console.ReadLine();

            // Output how many numbers are in this list
            List<int> numerals = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var howMany = numerals.Count();
            Console.WriteLine($"There are {howMany} numbers in this list.");
            Console.ReadLine();

        }
    }
}
