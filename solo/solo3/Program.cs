using System;

namespace Solo3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);

            Console.WriteLine($"magic number: {num}");
            int guess;
            do
            {
                Console.WriteLine($"Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                string guessByUser;
                if (guess > num)
                {
                    guessByUser = "lower";
                }
                else
                {
                    guessByUser = "higher";
                }
                Console.WriteLine($"{guessByUser}");

            } while (guess != num);

            Console.WriteLine("done!");
        
        }
    }
}