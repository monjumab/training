﻿using System;
using System.Collections;
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
            //Displaying students' age
            var student1 = new Student("Amy", Convert.ToDateTime("2000/02/18"));
            student1.Age();
            Console.WriteLine(student1);

            var student2 = new Student("Tom", Convert.ToDateTime("1982/04/17"));
            student2.Age();
            Console.WriteLine(student2);


            //Finding the highest paid employee
            var employees = new List<Employee>
            {
                new Employee(1, "John", 30000),
                new Employee(2, "Charlotte", 20000),
                new Employee(3, "Jacob", 15000),
                new Employee(4, "Jim", 89250),
                new Employee(5, "Mark", 652),
                new Employee(6, "Chris", 4569),
                new Employee(7, "Steve", 54180),
                new Employee(8, "Rory", 54681)
            };

            Employee highestPaidEmp = null;
            foreach (Employee employee in employees)
            {
                if (highestPaidEmp == null || employee.Salary > highestPaidEmp.Salary)
                {
                    highestPaidEmp = employee;
                }
            }
            Console.WriteLine(highestPaidEmp);
        }
    }
}
