using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2ndattempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string myString = Console.ReadLine();
            Console.WriteLine( myString.SequenceEqual(myString.Reverse()));
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
