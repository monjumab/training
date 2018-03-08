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
            var student1 = new Student("Amy", Convert.ToDateTime("2000/02/18"));
            student1.Age();

            Console.WriteLine(student1);

            var student2 = new Student("Tom", Convert.ToDateTime("1982/04/17"));
            student2.Age();

            Console.WriteLine(student2);
        }

    }
}
