//CheckTwoNumbers
//checks to numbers for one negative and one positive
//exception handling error

using System;

namespace Check_two_number
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            var a = Console.ReadLine();
            Console.WriteLine("enter second number: ");
            var b = Console.ReadLine();
            if (Isnumeric(a) > 0 && Isnumberic(b) < 0)
                Console.WriteLine("one of your numbers is possitive and the other is negative");
            else if (Isnumeric(a) < 0 && Isnumeric(b) > 0)
                Console.WriteLine("one of your numbers is possitive and the other is negative");
            else
                Console.WriteLine("either both numbers are negative or both possitive");
         


        }

        private static int Isnumberic(string b)
        {
            throw new NotImplementedException();
        }

        private static int Isnumeric(string a)
        {
            throw new NotImplementedException();
        }
    }
}
