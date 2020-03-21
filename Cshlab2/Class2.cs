using System;
using System.Collections.Generic;
using System.Text;

namespace Cshlab2
{
    class Program2
    {
        public Program2()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            char[] ss = new char [5];
            Console.WriteLine("Random string:");
            int p1 = 26, p2 = (int)Math.Pow(26, 2), p3 = (int)Math.Pow(26, 3), p4 = (int)Math.Pow(26, 4);
            int p = rnd.Next() % (1 + p1 + p2 + p3 + p4);
            int x = 1;
            while (x <= p)
            {
                p -= x;
                x *= 26;
            }
            if (x > p3)
                ss[3] = (char)(p / p3 + 'a');
            if (x > p2)
                ss[2] = (char)(p % p3 / p2 + 'a');
            if (x > p1)
                ss[1] = (char)(p % p3 % p2 / p1 + 'a');
            if (x > 1)
                ss[0] = (char)(p % p3 % p2 % p1 + 'a');


            Console.WriteLine(ss);

            Console.ReadKey();
        }
    }
}
