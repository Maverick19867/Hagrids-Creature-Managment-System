using System;

namespace HagridsCMS
{
    class Program
    {
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


        }
    }
}