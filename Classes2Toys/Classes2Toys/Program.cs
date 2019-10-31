using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace Classes2Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";
            string toyName;
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Nintendo";
            toy1.Name = "Switch";
            toy1.Price = 250;
            toy1.GetAisle();

            Console.WriteLine($"Manufacturer is: {toy1.Manufacturer}, Name is: {toy1.Name}, Price is: {toy1.Price}, Aisle is: {toy1.GetAisle()}.");

            List<Toy> listToys = new List<Toy>();

            do
            {
                Console.WriteLine("What toy do you want to add to the toy box?");
                toyName = Console.ReadLine();
                //listToys.Add(Console.ReadLine());

                Console.WriteLine("Do you want to add another toy?");
                answer = Console.ReadLine();
            }
            while (answer == "Yes");

         

            
        }
    }
}
