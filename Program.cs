using System;


namespace HagridsCMS
{
    class Program
    {

        static List<Assigment> assigments = new List<Assigment>();
        static void Main(string[] args)
        {
            List<Creature> hagridsList = new List<Creature>();

            hagridsList.Add(new Creature("Dudu", "Diricawl", 2, 4));
            hagridsList.Add(new Creature("Ignis", "Dragon(ChinesFireball)", 10, 150));
            hagridsList.Add(new Creature("Slimy", "Flobberworm", 1, 2));
            hagridsList.Add(new Creature("Fawkes", "Phoenix", 5, 50));
            hagridsList.Add(new Creature("Barney", "Ghoul", 3, 85));
            hagridsList.Add(new Creature("Griphook", "Goblin", 4, 32));
            hagridsList.Add(new Creature("Aragog", "Acromantula", 6, 30));
            hagridsList.Add(new Creature("Sly", "Horned Serpent", 8, 120));

            List<Student> students = new List<Student>();
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

            Console.WriteLine("===========================================");
            Console.WriteLine("    HAGRIDS AKTUELLER PFLEGE-DIENSTPLAN    ");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            foreach (var job in assignments)
            {
                job.PrintAssignmentDetails();
            }

            Console.WriteLine("Drücke eine Taste zum Beenden...");
            Console.ReadKey();

        }

        public static void AssignCreature(Student s, Creature c)
        {
            MemberAssignment newAssignment = new Assignment(s,c);

            assignments.Add(newAssignment);

            Console.WriteLine($"System: {s.Name} wurde erfolgreich für {c.Name} eingetragen.");
        }

    }
}