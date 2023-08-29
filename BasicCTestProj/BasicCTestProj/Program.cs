using System;
using System.Linq;

namespace BasicCTestProj
{
   
    class Program
    {
        // Reverse Number and Sum of given number
        public static void ReverseNumber(){
            Console.WriteLine("Input given number:");
            int inputValue = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (inputValue > 0)
            {
                int reminder = inputValue % 10;
                inputValue = inputValue / 10;

                sum = sum + reminder;

                Console.Write("{0}" + " ", reminder);
            }

            Console.WriteLine("The sum of given input is {0}", sum);

            Console.ReadLine();

        }

        // Reverse String
        // Reverse Array Same as String
        public static void ReverseString()
        {
            Console.WriteLine("Input Data:");
            string data = Console.ReadLine();

            char[] ChArray = data.ToCharArray();
            Array.Reverse(ChArray);
            Console.WriteLine(ChArray);
        }

        // swap 2 number
        public static void Swap2number()
        {
            int a, b;
            Console.WriteLine("Input Data a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Data b:");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("After swaping a and b data: {0} and {1}", a,b);
        }

        static void Main(string[] args)
        {
            //ReverseString();
            ReverseNumber();
            //Swap2number();
            Console.Read();
        }
    }
}
