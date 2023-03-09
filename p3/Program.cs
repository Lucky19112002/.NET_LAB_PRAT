using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int totNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < totNum; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
