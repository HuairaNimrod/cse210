using System.Collections.Generic;

namespace Polymorphism
{
    class Polymorphism
    {

        static void Main()
        {
            // create different kinds of employees...
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            employees.Add(new HourlyEmployee());

            // get a custom calculation for each one
            foreach(Employee employee in employees)
            {
                float pay = employee.CalculatePay();
                Console.WriteLine(pay);
            }
        }       
    }


} 