using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            num = 0;

            while (num <= 100) 
            {
                Console.WriteLine(num);

                num += 2;
            }

            Console.ReadKey();
        }
    }
}
