using System;
namespace Check_two_number
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            
            var a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("enter second number: ");
            
            var b = Int32.Parse(Console.ReadLine());

            if (a > 0 && b < 0)
            {
                Console.WriteLine("one of your numbers is possitive and the other is negative");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("one of your numbers is possitive and the other is negative");
            }
            else
            {
                Console.WriteLine("either both numbers are negative or both possitive");
            }
                
                



        }
    }
}

//vars now parsed to ints
//crashes if chars are entered. need to verify user input is an int and handle exception
