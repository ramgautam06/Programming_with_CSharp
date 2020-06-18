using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Programming
{
    class Program
    {
        public static void Goodday()
        {
            Console.WriteLine("Have Good Day");
        }

        public static void print_fullname()
        {
            string firstname = "Ram";
            string lastname = "Gautam";

            Console.WriteLine(firstname + " " + lastname);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wolrd !! I am C#");

            // Modify the sample program to print "Good Day"
            Goodday();

            //Console Application that prints first and last name 
            print_fullname();

            Console.Read();
        }
    }
}
