using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Student
    {
        public void Age()
        {
            DateTime dateOfBirth = Convert.ToDateTime("1998/08/07");
            string age = CalculateAge(dateOfBirth);

            Console.WriteLine("You are " + age + " years old.");


            string CalculateAge(DateTime birthDate)
            {
                int years = DateTime.Now.Year - birthDate.Year;

                if (birthDate.Month > DateTime.Now.Month || birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day)
                {
                    years--;
                }

                return years.ToString();
            }

        }
       
       
    }
}
