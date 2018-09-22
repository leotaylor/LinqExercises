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

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var howMuch = purchases.Sum();
            var currency = String.Format($"{howMuch:C}");
            Console.WriteLine($"We have made {currency}!");
            Console.ReadLine();

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var highestPrice = prices.Max();

            Console.WriteLine($"Our highest price is {String.Format($"{highestPrice:C}")}.");
            Console.ReadLine();

            
            //Store each number in the following List until a perfect square is detected 

            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            var partitioned = wheresSquaredo.TakeWhile(square => Math.Sqrt(square) % 1 != 0);

            Console.WriteLine("Store each number in the following List until a perfect square is detected: 66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14 : ");

            foreach (var number in partitioned)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();


            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            List<Customer> millionaires = new List<Customer>();

            foreach(var customer in customers)
            {
                if(customer.Balance >= 1000000)
                {
                    millionaires.Add(customer);
                }
            }

            foreach(var millionaire in millionaires)
            {
                Console.WriteLine(millionaire.Name);
            }
            Console.ReadLine();
        }
    }
}
