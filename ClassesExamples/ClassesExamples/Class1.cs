using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExamples
{
    class Student
    {
        private string name;

        private int id;

        public string city { get; set; }

        public int getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setID(int newID)
        {
            id = newID;
        }
       
        public Student()
        {
            id = 0;
            name = string.Empty; //"
        }

    }
}
