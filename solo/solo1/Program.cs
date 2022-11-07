using System;

namespace Solo1
{
    public class Program
    {
        public static void Main(string[] args){

            Console.Write("Whats your first name? ");
            string firstname= Console.ReadLine();
            Console.Write("Whats your last name? ");
            string lastname= Console.ReadLine();
            Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

        }
    }
}