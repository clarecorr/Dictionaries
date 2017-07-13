using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax for dictionary
            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Twix" },
                {"A2", "Twizzlers" },
                {"A3", "Reeses" },
                {"A4", "Sour Patch Kids" }
            };
            foreach (KeyValuePair<string, string> item in snackMachine)
            {
                //Console.WriteLine(item);
            }

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using add method to add drinks
            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Orange Juice");
            drinkMachine.Add(13, "Fruit Punch");
            drinkMachine.Add(14, "Mountain Dew Code Red");

            //counting the number of entries in the dictionary
            //Console.WriteLine(drinkMachine.Count());

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}

            //create a dictionary for a theater coat check with 10 elements
            //the key will be a number and value will be coat style
            //print all elements to the console

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            //{
            //    {1, "Jean Jacket" },
            //    {2, "Parka" },
            //    {3, "Raincoat" },
            //    {4, "Trench" },
            //    {5, "Windbreaker" },
            //    {6, "Bomber Jacket" },
            //    {7, "Leather Jacket" },
            //    {8, "Vest" },
            //    {9, "Peacoat" },
            //    {10, "Army Jacket" }
            //};
            //foreach(KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat);
            //}

            //Car valet with 10 cars the key will be a customers last name and the value will be the car make
            //print all elements to the console

            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Watkins", "Honda" },
            //    {"Burjek", "Toyota" },
            //    {"O'Brien", "Volvo" },
            //    {"Reyes", "Chevy" },
            //    {"Murphy", "Ford" },
            //    {"Yusko", "Nissan" },
            //    {"Madden", "Mitsubishi" },
            //    {"Guzman", "BMW" },
            //    {"Rao", "Lexus" },
            //    {"Hartsell", "Buick" }
            //};
            //carValet["Corrigan"] = "Tesla";
            //foreach (KeyValuePair<string, string> car in carValet)
            //{
            //    Console.WriteLine(car);
            //}
            //Console.WriteLine(carValet["Corrigan"]);
            //string maddenCar;
            //carValet.TryGetValue("Madden", out maddenCar);
            //Console.WriteLine(maddenCar);
            //if (carValet.ContainsKey("Buick"))
            //{
            //    Console.WriteLine("true");
            //}
            //create a dictionary of 10 zoo animals the key will be the animal type the value will be the number
            //of animals
            //print the animals with the highest quantity to the console
            //remove the zoo animal with the lowest quantity using Remove()

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Elephant", 5 },
                {"Tiger", 3 },
                {"Lion", 5 },
                {"Jaguar", 6 },
                {"Camel", 2 },
                {"Giraffe", 6 },
                {"Wolf", 10 },
                {"Penguin", 20 },
                {"Chimp", 8 },
                {"Gorilla", 4 }
            };

            int hightestQuantity = 0;
            foreach (KeyValuePair<string, int> pair in zooAnimals)
            {
                if (pair.Value > hightestQuantity)
                {
                    hightestQuantity = pair.Value;
                }
            }

            foreach (KeyValuePair<string, int> pair in zooAnimals)
            {
                if (pair.Value == hightestQuantity)
                {
                    Console.WriteLine("Most animals: " + pair);
                }
            }

            int lowestQuantity = 5;
            foreach (KeyValuePair<string, int> pair in zooAnimals)
            {
                if (pair.Value < lowestQuantity)
                {
                    lowestQuantity = pair.Value;
                }
            }

            string lowestQuantityKey = "";
            foreach (KeyValuePair<string, int> pair in zooAnimals)
            {
                if (pair.Value == lowestQuantity)
                {
                    lowestQuantityKey = pair.Key;
                }
            }
            zooAnimals.Remove(lowestQuantityKey);
            Console.WriteLine("Animals left: ");
            foreach (KeyValuePair<string, int> pair in zooAnimals)
            {
                Console.WriteLine(pair);
            }


            
            
            
            
            
            
            ////IEnumerator ??
            //var items = from pair in zooAnimals
            //            orderby pair.Value descending
            //            select pair;


            //foreach (KeyValuePair<string, int> pair in items)
            //{
            //    if (pair.Value == hightestQuantity)
            //    {
            //        Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            //    }
            //}



        }
    }
}
