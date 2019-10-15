using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
/*Create a function and name it GetDoubleInputFromUser, that will have a return type of double. 
 *Your function should accept 1 parameter, of type string, which will contain the message you want to ask the user. 
Your function should ask the message passed in as an argument and get the users response.  
You should validate that the response the user gave you is of type double (using double.TryParse ...), if it is not, you need to re-prompt them until they give you a valid input.  
After you have a valid input from the user, return the converted value.
Your main() function should call your GetDoubleInputFromUser function and multiply the users response by 5.
Output the equation and result to the user (e.g. If the user entered the value 10 you would output, "10 * 5 = 50")
*/
namespace GetDoubleInputFromUser
{
    class Program
    {
        static double GetDoubleInputFromUser(string msg)
        {
            string userInput;
            string validOrNot;
            double newVal;

            do
            {
                Console.WriteLine(msg);
                userInput = Console.ReadLine();

                bool valid = double.TryParse(userInput, out newVal);

                if (valid)
                {
                    validOrNot = "valid";
                }
                else
                {
                    validOrNot = "not";
                }

            } while (validOrNot == "not");

            return newVal;

        }
        static void Main(string[] args)
        {
            string msg = "Please input a value.";
            

            double calc = GetDoubleInputFromUser(msg);

            Console.WriteLine($" {calc} * 5 = {calc * 5}");
            calc = GetDoubleInputFromUser("Get GPA");
            Console.WriteLine($" {calc} * 5 = {calc * 5}");
            Console.ReadKey();
            
        }
    }
}
