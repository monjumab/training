using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Student studentAge = new Student();
            //studentAge.Age();

            //Employee workers = new Employee();
            //workers.EmployeeInfo();

            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Average is: " + average);

        }
    }
}
