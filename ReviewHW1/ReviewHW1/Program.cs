using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace ReviewHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            const double csaleTax = .085;
            double price;
            double quantity;
            string item, priceAsString, quantityAsString;

            //Get Input from the user
            Console.WriteLine("What type of item are you purchasing?");
            item = Console.ReadLine();

            Console.WriteLine($"How many {item}s do you want to buy?");
            quantityAsString = Console.ReadLine();
            
            Console.WriteLine($"What is the price for each {item}?");
            priceAsString = Console.ReadLine();

            //Convert strings to number data types
            price = Convert.ToDouble(priceAsString);
            quantity = Convert.ToDouble(quantityAsString);

            double subTotal = price * quantity;
            double salesTax = subTotal * csaleTax;
            double salesTotal = subTotal + salesTax;

            //Output to the user
            Console.WriteLine($"Your subtotal for your bill is {subTotal.ToString("C2")}.");
            Console.WriteLine($"Your sales tax for your bill is {salesTax.ToString("C2")}.");
            Console.WriteLine($"Your total for your bill is {salesTotal.ToString("C2")}.");


            Console.ReadKey();



        }
    }
}
