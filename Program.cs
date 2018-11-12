using System;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleClasses
{
    public class Test
    {
        static void Main()
        {
            Student studentdj = new Student("Marko", "Pavlovic");
            Group mata = new Group("Mata");
            Teacher t = new Teacher("Zorka","Zokic");

            mata.Teacher = t;
            mata.Students.Add(studentdj);
            t.Groups.Add(mata);

            School skola = new School("Gimnazija");
            skola.Groups.Add(mata);
            skola.Students.Add(studentdj);
            skola.Teachers.Add(t);
            Console.WriteLine(skola);
            Console.ReadLine();
        }
    }
}
