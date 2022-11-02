using System;

namespace Solo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter the grade percentage: ");
            string number= Console.ReadLine();
            int percentage = int.Parse(number);
            string letter; 
            if (percentage>=90){
                letter = "A";   
            }
            else if(percentage>=80){
                letter = "B";
            }
            else if(percentage>=70){
                letter = "C";
            }
            else if(percentage>=60){
                letter = "D";
            }
            else {
                letter = "F";
            }
            string sign;
            int modulus =  percentage%10;
            if (modulus >= 7){
                sign = "+" ;
            }
            else if (modulus<3){
                sign = "-";
            }
            else{
                sign="";
            }
            
            Console.WriteLine($"Your letter is {letter}{sign}");
        }
    }
}
    