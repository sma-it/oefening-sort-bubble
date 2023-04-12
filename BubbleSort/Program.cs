using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace BubbleSort
{
    class Program
    {
        public class Person
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string buzzword { get; set; }

            public override string ToString()
            {
                return $"First Name: {first_name}, Last Name: {last_name}, Email: {email}, Gender: {gender}, Buzzword: {buzzword}";
            }
        }

        static void Main(string[] args)
        {
            string jsonFilePath = "../../../MOCK_DATA.json";

            List<Person> people = ReadJsonFile(jsonFilePath);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSort(people);

            stopwatch.Stop();



            Console.WriteLine("Time taken for Bubble Sort: " + stopwatch.Elapsed);

            // Print the first 10 elements of the sorted list
            Console.WriteLine("\nFirst 10 elements of the sorted list:");
            for (int i = 0; i < 10 && i < people.Count; i++)
            {
                Console.WriteLine(people[i].ToString());
            }

            // Print the last 10 elements of the sorted list
            Console.WriteLine("\nLast 10 elements of the sorted list:");
            for (int i = people.Count - 10; i < people.Count; i++)
            {
                Console.WriteLine(people[i].ToString());
            }
        }

        static List<Person> ReadJsonFile(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonContent);
            return people;
        }

        static void BubbleSort(List<Person> people)
        {
            // implement the sort
        }
    }
}
