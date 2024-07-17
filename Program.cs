using College.Models;

namespace College
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(100, "Lotus Park", new DateOnly(2000,10,24));
            Student student = new Student(101, "Andheri", new DateOnly(2002, 3,16), "Machine Learning");
            Professor professor = new Professor(102, "Kandivali", new DateOnly(2003, 12, 13), 56000);

            PrintDetails(person);
            PrintDetails(student);
            PrintDetails(professor);

        }

        static void PrintDetails(Person person)
        {
            Console.WriteLine($"================== {person.GetType().Name} ===================");
            Console.WriteLine(person.PrintDetails());
        }
    }
}
