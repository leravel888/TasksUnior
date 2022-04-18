using System;
 
namespace ConsoleApp1
{
    class Task5
    {             
        static void Main()
        {           
            string firstName = "aaa";
            string lastName = "bbb";
            string tmpReplacement = firstName;

            Console.WriteLine("{0} {1}" , firstName, lastName);

            firstName = lastName;
            lastName = tmpReplacement;

            Console.WriteLine("{0} {1}", firstName, lastName);

            Console.ReadLine();
        }
    }
}
