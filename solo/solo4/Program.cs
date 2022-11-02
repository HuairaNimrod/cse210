using System;
using System.Collections.Generic;
namespace solo4
{
    class Program
    {
        static void Main(string[] args){

            int numberInt;
            List<int> numbers = new List<int>();
            Console.Write("Enter a list of numbers, type 0 when finished. \n");
            do{
            
            Console.Write($"Enter number: ");
            numberInt = int.Parse(Console.ReadLine());
            numbers.Add(numberInt);
            }while(numberInt!=0);
        }
    }
}