using System;
using System.Text;

namespace Cshlab2
{
    class Program
    {
        static void Main(string[] args)
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
    class Program1
    {
        public Program1()
        {
            DateTime now = DateTime.Now;
            int[] mas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string s;
            s = now.ToString("MM-dd-yyyy hh:mm:ss");
            for (int i = 0; i < s.Length; i++)
                if (s[i] <= '9' && s[i] >= '0')
                    mas[s[i] - '0']++;
            Console.WriteLine("{0} (usa)", s);
            Console.WriteLine(now.ToString("dd.MM.yyyy hh:mm:ss") + " (normal)");
            for (int i = 0; i <= 9; i++)
                Console.WriteLine("Count of {0} is {1}", i, mas[i]);
            Console.ReadKey();
        }
    }
    class Program2
    {
        public Program2()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < 4; i++)
                s.Append((char)rnd.Next('a', 'z'));

            Console.WriteLine("Random string:");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
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
