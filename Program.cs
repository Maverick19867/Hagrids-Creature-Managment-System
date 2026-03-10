using System;
using System.Collections.Generic;

namespace HagridsCMS
{
    class Program
    {
        static List<Assignment> assignments = new List<Assignment>();
        static List<Creature> hagridsList = new List<Creature>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            InitializeData();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("    HAGRID'S CREATURE MANAGEMENT SYSTEM    ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Add Creature");
                Console.WriteLine("2. Show Creatures");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4. Assign Creature (Manual)");
                Console.WriteLine("5. Show Assignments");
                Console.WriteLine("6. Statistics");
                Console.WriteLine("7. Exit");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Wähle eine Option (1-7): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCreatureManual();
                        break;
                    case "2":
                        ShowCreatures();
                        break;
                    case "3":
                        AddStudentManual();
                        break;
                    case "4":
                        MakeManualAssignment();
                        break;
                    case "5":
                        ShowAssignments();
                        break;
                    case "6":
                        ShowStatistics();
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Programm wird beendet...");
                        break;
                    default:
                        Console.WriteLine("Ungültige Option. Bitte wähle 1-7.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void InitializeData()
        {
            hagridsList.Add(new Creature("Dudu", "Diricawl", 2, 4));
            hagridsList.Add(new Creature("Ignis", "Dragon(ChinesFireball)", 10, 150));
            hagridsList.Add(new Creature("Slimy", "Flobberworm", 1, 2));
            hagridsList.Add(new Creature("Fawkes", "Phoenix", 5, 50));
            hagridsList.Add(new Creature("Barney", "Ghoul", 3, 85));
            hagridsList.Add(new Creature("Griphook", "Goblin", 4, 32));
            hagridsList.Add(new Creature("Aragog", "Acromantula", 6, 30));
            hagridsList.Add(new Creature("Sly", "Horned Serpent", 8, 120));

            students.Add(new Student("Harry Potter", "Gryffindor", 3));
            students.Add(new Student("Hermione Granger", "Gryffindor", 3));
            students.Add(new Student("Ron Weasley", "Gryffindor", 3));
            students.Add(new Student("Draco Malfoy", "Slytherin", 3));
            students.Add(new Student("Luna Lovegood", "Ravenclaw", 2));
            students.Add(new Student("Neville Longbottom", "Gryffindor", 3));
            students.Add(new Student("Cho Chang", "Ravenclaw", 4));
            students.Add(new Student("Seamus Finnigan", "Gryffindor", 3));

            AssignCreature(students[0], hagridsList[7]);
            AssignCreature(students[1], hagridsList[6]);
            AssignCreature(students[2], hagridsList[5]);
            AssignCreature(students[3], hagridsList[4]);
            AssignCreature(students[4], hagridsList[3]);
            AssignCreature(students[5], hagridsList[2]);
            AssignCreature(students[6], hagridsList[1]);
            AssignCreature(students[7], hagridsList[0]);
        }

        public static void AssignCreature(Student s, Creature c)
        {
            Assignment newAssignment = new Assignment(s, c);
            assignments.Add(newAssignment);
            Console.WriteLine($"System: {s.Name} wurde für {c.Name} eingetragen.");
        }

        static void ShowCreatures()
        {
            Console.Clear();
            Console.WriteLine("=== ALLE KREATUREN ===");
            foreach (var c in hagridsList) c.PrintInfo();
            Console.WriteLine("\nDrücke eine Taste zum Zurückkehren...");
            Console.ReadKey();
        }

        static void ShowAssignments()
        {
            Console.Clear();
            Console.WriteLine("=== AKTUELLE PFLEGE-DIENSTPLAN ===");
            foreach (var a in assignments) a.PrintAssignmentDetails();
            Console.WriteLine("\nDrücke eine Taste zum Zurückkehren...");
            Console.ReadKey();
        }

        static void ShowStatistics()
        {
            Console.Clear();
            Console.WriteLine("=== STATISTIKEN ===");
            Console.WriteLine($"Anzahl der Kreaturen: {hagridsList.Count}");
            Console.WriteLine($"Anzahl der Studenten: {students.Count}");
            Console.WriteLine($"Anzahl der Zuweisungen: {assignments.Count}");
            Console.WriteLine("\nDrücke eine Taste zum Zurückkehren...");
            Console.ReadKey();
        }

        static void AddCreatureManual()
        {
            Console.Clear();
            Console.WriteLine("=== KREATUR HINZUFÜGEN ===");
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("Spezies: ");
            string s = Console.ReadLine();
            Console.Write("Gefahr (1-10): ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Alter: ");
            int a = int.Parse(Console.ReadLine());

            hagridsList.Add(new Creature(n, s, d, a));
            Console.WriteLine("Erfolg! Drücke eine Taste...");
            Console.ReadKey();
        }

        static void AddStudentManual()
        {
            Console.Clear();
            Console.WriteLine("=== STUDENT HINZUFÜGEN ===");
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("Haus: ");
            string h = Console.ReadLine();
            Console.Write("Jahrgang: ");
            int y = int.Parse(Console.ReadLine());

            students.Add(new Student(n, h, y));
            Console.WriteLine("Erfolg! Drücke eine Taste...");
            Console.ReadKey();
        }

        static void MakeManualAssignment()
        {
            Console.Clear();
            Console.WriteLine("=== MANUELLE ZUWEISUNG ===");
            for (int i = 0; i < students.Count; i++) 
                Console.WriteLine($"{i}: {students[i].Name}");
            
            Console.Write("Wähle Student Index: ");
            int sIdx = int.Parse(Console.ReadLine());

            for (int i = 0; i < hagridsList.Count; i++) 
                Console.WriteLine($"{i}: {hagridsList[i].Name}");
            
            Console.Write("Wähle Kreatur Index: ");
            int cIdx = int.Parse(Console.ReadLine());

            AssignCreature(students[sIdx], hagridsList[cIdx]);
            Console.ReadKey();
        }
    }
}