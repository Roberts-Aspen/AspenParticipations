using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Student
{
    class Student
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FavoriteColor { get; set; }

        public Student()
        {
            StudentID = 0;
            FirstName = "";
            LastName = "";
            FavoriteColor = "";
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName} - {FavoriteColor}";
        }
    }
}
