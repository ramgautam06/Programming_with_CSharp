using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitive_Types_and_Variables
{
    class Program
    {
        /*A company dealing with marketing wants to keep a data record of its employees.
         * Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number(27560000 to 27569999).
         * Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
         */
        public static void employees()
        {
            string firstname;
            string lastname;
            int age;
            char gender;
            int ID;
        }

        /*Declare two variables of type int. Assign to them values 5 and 10 respectively.Exchange(swap) their values and print them.*/
        public static void swap_numbers()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("The value of a = " + a + " b = " + b + " before swapping ");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("The value of a = " + a + " b = " + b + " after swapping ");

        }

        static void Main(string[] args)
        {
            //employees();
            swap_numbers();

            Console.ReadLine();
        }
    }
}
