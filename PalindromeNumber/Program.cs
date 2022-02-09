using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking for palindrome number
            int userNumber; //Original number - user input
            int tempNumber;
            int remainder;
            int reverseNumber = 0;
            Console.WriteLine("\t");
            Console.Write("Enter an integer number to check palindrome: ");
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            tempNumber = userNumber;

            Console.WriteLine("************Logic of Computation***********");
            Console.WriteLine("******Before While Loop");
            Console.WriteLine("Orginal number entered by user =" + userNumber);
            Console.WriteLine("Temporary Number  =" + tempNumber);
            Console.WriteLine("Reverse Number  =" + reverseNumber);
            Console.WriteLine("\n\n");


            Console.WriteLine("********* While Loop Begins **************");
            while (userNumber > 0)
            {
                remainder = userNumber % 10;
                Console.WriteLine("Remainder = " + remainder);
                reverseNumber = reverseNumber * 10 + remainder;
                Console.WriteLine("Reverse Number = " + reverseNumber);
                userNumber /= 10;
                Console.WriteLine("user Original number " + userNumber);
                Console.WriteLine("Iteration Completed\\n");
            }


            Console.WriteLine("*********** While Loop End ***************");
            Console.WriteLine("\n\n");

            Console.WriteLine("********** After While loop ***************");
            Console.WriteLine(" **************** Find Reverse Number *******");
            Console.WriteLine("Original User Number {0}", tempNumber);
            Console.WriteLine("Reverse Number: {0}", reverseNumber);

            Console.WriteLine("*********** The End *************** \n");



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
