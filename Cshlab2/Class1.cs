using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cshlab2
{
    class Program1
    {
        public Program1()
        {
            DateTime now = DateTime.Now;
            int[] mas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string s;
            s = now.ToString("MM-dd-yyyy hh:mm:ss tt",CultureInfo.InvariantCulture);
            for (int i = 0; i < s.Length; i++)
                if (s[i] <= '9' && s[i] >= '0')
                    mas[s[i] - '0']++;
            Console.WriteLine("{0} (usa)", s);
            Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss") + " (normal)");
            for (int i = 0; i <= 9; i++)
                Console.WriteLine("Count of {0} is {1}", i, mas[i]);
            Console.ReadKey();
        }
    }

}