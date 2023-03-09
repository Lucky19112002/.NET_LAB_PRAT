using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7
{
    class Program
    {

        public static string numberToWords(int number)
        {
            if (number == 0)
                return "zero";
            if (number < 0)
                return "minus " + numberToWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
                words += numberToWords(number / 1000000) + " million "; number %= 1000000;
            if ((number / 1000) > 0)
                words += numberToWords(number / 1000) + " thousand "; number %= 1000;
            if ((number / 100) > 0)
                words += numberToWords(number / 100) + " hundred "; number %= 100;
            if (number > 0)
            {
                string[] units_value = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens_value = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                if (number < 20)
                    words += units_value[number];
                else
                {
                    words += tens_value[number / 10];
                }
                if ((number % 10) > 0)
                    words += "-" + units_value[number % 10];
            }
            return words;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the valid value : ");
            int getvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In words: " + numberToWords(getvalue));
            Console.ReadLine();
        }
    }
}
