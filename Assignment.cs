using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HagridsCMS
{
    public class Assignment
    {
        public Student Student { get; set; }
        public Creature Creature { get; set; }
        public DateTime DateAssigned { get; set; }

        public Assignment(Student student, Creature creature)
        {
            Student = student;
            Creature = creature;
            DateAssigned = DateTime.Now;
        }

        public void PrintAssignmentDetails()
        {
            Console.WriteLine("=== PFLEGE-ZUWEISUNG ===");
            Console.WriteLine($"Schüler: {Student.Name} ({Student.House})");
            Console.WriteLine($"Kreatur: {Creature.Name}der {Creature.Species}");
            Console.WriteLine($"Gefahrenstufe der Aufgabe: {Creature.DangerLevel}");
            Console.WriteLine($"Zugeordnet am: {DateAssigned.ToShortDateString()}");
            Console.WriteLine("========================");
        }
    }
}
