using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public int Salary { get; }

        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}.";
        }
    }
}
