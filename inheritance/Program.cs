using System;

namespace Inheritance
{
    class Program{

        static void Main()
        {
            Student student = new Student("123123");
            string name = student.GetName();
            Console.WriteLine($"\n{name}\n");


            

            Estudiante estudiante = new Estudiante("01246813579");
            string number = estudiante.GetNumber();
            Console.WriteLine($"{number}\n");
           
        }

        public class Student : Person
        {
          public Student(string number): base(number)
          {

          }
        }

        public class Estudiante : Person
        {
            public Estudiante(string number): base(number)
            {

            }
        }
    }
}