using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if statement

            //test can be true or false
            bool isMale = true;

            if (isMale)
            {
                Console.WriteLine("you are male");
            }
            else
            {
                Console.WriteLine("you are female");
            }
            //testing 2 conditions
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("you are both male and tall");
            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("you are not tall but u are male");
            }
            else { Console.WriteLine("u are either not tall or not a male"); }
        }
    }
}
