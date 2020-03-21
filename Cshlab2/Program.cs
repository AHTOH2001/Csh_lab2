using System;
using System.Text;

namespace Cshlab2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose problem(0 to exit):");
            Console.WriteLine("1. variant 1");
            Console.WriteLine("2. variant 9");
            Console.WriteLine("3. variant 12");
            char c = '*';
            while (c <= '0' || c >= '4')
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (c == '1')
                    new Program1();
                else if (c == '2')
                    new Program2();
                else if (c == '3')
                    new Program3();
                else if (c == '0')
                {
                    Console.WriteLine("Successfully exit");
                    break;
                }
                else
                    Console.WriteLine("Error, try again");
            }
          //  Console.ReadKey();
        }
    }
   
   
}
