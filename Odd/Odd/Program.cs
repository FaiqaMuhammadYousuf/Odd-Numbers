using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Numbers");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
