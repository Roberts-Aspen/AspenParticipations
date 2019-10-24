using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Aspen";

            Student myStudent = new Student();

            myStudent.setName(myName);

            myStudent.setID(5);

            Console.WriteLine(myStudent.getName() + " ");

            Console.ReadKey();
        }
    }
}
