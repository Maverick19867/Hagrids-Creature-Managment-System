
using System;

namespace HagridsCMS
{
    public class Creature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int DangerLevel { get; set; }
        public int Age { get; set; }

        public Creature(string name, string species, int dangerLevel, int age)
        {
            Name = name;
            Species = species;
            DangerLevel = dangerLevel;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Danger Level: {DangerLevel}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("-------------------------");
        }
    }
}