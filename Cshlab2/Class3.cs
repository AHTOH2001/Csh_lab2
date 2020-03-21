using System;
using System.Collections.Generic;
using System.Text;

namespace Cshlab2
{
    class Program3
    {
        public Program3()
        {
            Console.WriteLine("Enter strings separated by spaces");
            Console.WriteLine("consisting of Russian and English letters");
            string[] a = Console.ReadLine().Split();
            bool[] fs = new bool[a.Length];
            int p = -1;
            for (int i = 0; i < a.Length; i++)
            {
                fs[i] = true;
                for (int j = 0; j < a[i].Length; j++)
                    if ((a[i][j] >= 'a' && a[i][j] <= 'z') || (a[i][j] >= 'A' && a[i][j] <= 'Z'))
                    {
                        fs[i] = false;
                        break;
                    }
                if (fs[i] && (p == -1 || a[i].Length > a[p].Length)) p = i;
            }


            for (int i = 0; i < a.Length; i++)
                if (fs[i])
                    Console.WriteLine(a[i].PadLeft(a[p].Length));



            Console.ReadKey();
        }
    }
}
