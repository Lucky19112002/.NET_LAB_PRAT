using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Hi, " + name + " from country " + country + "!");
            Console.ReadLine();
        }
    }
}
