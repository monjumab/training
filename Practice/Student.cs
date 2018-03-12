using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Student
    {
        public string Name { get; }
        public DateTime DateOfBirth { get;}

        public Student(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public int Age()
        {
            var now = DateTime.Today;
            var age = now.Year - DateOfBirth.Year;

            if (DateOfBirth.AddYears(age) > now) age--;
            return age;
        }

        public override string ToString()
        {
            return $"Name: {Name} and age is: {Age()}";
        }
    }
}
