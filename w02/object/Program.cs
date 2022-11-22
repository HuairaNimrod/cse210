namespace Object
{
    class Program
    {
        static void Main (string[] args)
        {

            ///Instance of a class with a constructor ==> Person()
            Person person = new Person();

                    /// set value to class Person variables
            person._name = "Nimrod";
            person._lastName = "Huaira";
            person.westernName();

            /// another way to create a Person instance

            Person person1 = new Person();
            person1._name = "Max";
            person1._lastName = "Baltazar";
            person1.easternName();
        }
    }
}