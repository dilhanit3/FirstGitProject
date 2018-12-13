using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laurie's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3 ");
            string userValue = Console.ReadLine();
            string message = "";

            //PART 1
            if (userValue == "1")
            {
                message = "You won a new car! ";
                //Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                message = "You won a new boat! ";
                //Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                message = "You won a new cat! ";
                //Console.WriteLine(message);
            }
            else
            {
                message = "Sorry, we didn't understand.";
                message = message + "You Lose. ";
                //Console.WriteLine(message);
            }
            Console.WriteLine(message);


            //PART TWO
            //Console.WriteLine("Laurie's Big Giveaway");
            //Console.Write("Choose a door: 1, 2 or 3 ");
            //string userValue = Console.ReadLine();
            //string message = "";

            //if (userValue == "1")
            //{
            //    message = "You won a new car! ";
            //}

            //else if (userValue == "2")
            //{
            //    message = "You won a new boat! ";
            //}
            //else if (userValue == "3")
            //{
            //    message = "You won a new cat! ";
            //}
            //else
            //{
            //    message = "Sorry, we didn't understand.";
            //    //the below two lines of code result in the same value within the message variable
            //    //message = message + "You Lose. ";
            //    //the below statement uses the concatenation and assignment operator
            //    message += "You Lose. ";
            //}

            //Console.WriteLine(message);
            //Console.ReadLine();

            //PART THREE -Conditional operator
            //Console.WriteLine("Laurie's Big Giveaway");
            //Console.Write("Choose a door: 1, 2 or 3 ");
            //string userValue = Console.ReadLine();

            //string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(" . ");
            //Console.ReadLine();

            //PART FOUR   Replacement Character with one 
            // Console.WriteLine("Laurie's Big Giveaway");
            // Console.Write("Choose a door: 1, 2 or 3 ");
            // string userValue = Console.ReadLine();
            // string message = (userValue == "1") ? "boat" : "strand of lint";
            // Console.Write("You won a ");
            // Console.Write(message);
            // Console.Write(" . ");
            // Console.ReadLine();
            // Console.WriteLine("You won a {0}. ", message);
            //Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            // Console.ReadLine();



        }
    }
}
