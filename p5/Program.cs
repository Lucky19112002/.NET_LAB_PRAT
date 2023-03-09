using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5
{
    class Program
    {
        private static void getbinaryToDecimal()
        {
            Console.Write("Enter the valid binary number: ");
            int binary = Convert.ToInt32(Console.ReadLine());
            int temp_binary = binary;
            int decimalNum = 0, cnt = 0;
            while (binary > 0)
            {
                decimalNum += binary % 10 * (int)Math.Pow(2, cnt++);
                binary /= 10;
            }
            Console.WriteLine("Equivalent Decimal Number is : " + decimalNum);
        }
        private static void getdecimalToBinary()
        {
            Console.Write("Enter the valid decimal number: ");
            int decimalValue = Convert.ToInt32(Console.ReadLine());
            int decimalNum = decimalValue;
            int binary = 0, cnt = 0;
            while (decimalValue > 0)
            {
                binary += decimalValue % 2 * (int)Math.Pow(10, cnt++);
                decimalValue /= 2;
            }
            Console.WriteLine("Equivalent Binary Number is: " + binary);
        }
        private static void getdecimalToHexa()
        {
            Console.Write("Enter the valid decimal number: ");
            int decimalValue = Convert.ToInt32(Console.ReadLine());
            string hex = "";
            while (decimalValue > 9)
            {
                int hexarem = decimalValue % 16;
                if (hexarem >= 10 && hexarem <= 15)
                    hex = (char)('A' + hexarem - 10) + hex;
                else
                    hex = (char)(hexarem + '0') + hex;
                decimalValue /= 16;
            }
            if (decimalValue > 0)
                hex = (char)(decimalValue + '0') + hex;
            Console.WriteLine("Equivalent Hexa Number is : " + hex);
        }
        private static void getdecimalToOctal()
        {
            Console.Write("Enter the valid decimal number: ");
            int decimalValue = Convert.ToInt32(Console.ReadLine());
            int octal = 0;
            int cnt = 0;
            while (decimalValue > 0)
            {
                octal += decimalValue % 8 * (int)Math.Pow(10, cnt++);
                decimalValue /= 8;
            }
            Console.WriteLine("Equivalent Octal Number is :" + octal);
        }
        static void Main(string[] args)
        {
            bool startloop = true;
            while (startloop)
            {
                Console.Clear();
                Console.WriteLine("1. Binary to Decimal");
                Console.WriteLine("2. Decimal to Binary");
                Console.WriteLine("3. Decimal to Hexdecimal");
                Console.WriteLine("4. Decimal to Octal");
                Console.WriteLine("5. Exit");
                Console.Write("Enter the valid choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: getbinaryToDecimal(); break;
                    case 2: getdecimalToBinary(); break;
                    case 3: getdecimalToHexa(); break;
                    case 4: getdecimalToOctal(); break;
                    case 5:
                        startloop = false;
                        Console.Write("Thanks for using an application !"); break;
                    default: Console.Write("Invalid choice, Try again !"); break;
                }
                Console.ReadLine();
            }
        }
    }
}
