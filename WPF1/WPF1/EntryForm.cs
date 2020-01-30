using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public EntryForm()
        {
            string Name = "";
            string Address = "";
            int ZipCode = 0;

        }

        public EntryForm(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }
        public override string ToString()
        {
            string over = Name + " " + Address + " " + ZipCode;

            return over;
        }
    }
}
