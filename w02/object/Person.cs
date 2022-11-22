using System;

    public class Person
    {
        public string _name = "";
        public string _lastName = "";

        public Person()
        {       
        }

        public void easternName()
        {
            Console.WriteLine($"{_lastName}, {_name}");
        }
        public void westernName()
        {
            Console.WriteLine($"{_name} {_lastName}");
        }
    }

