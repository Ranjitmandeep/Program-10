using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_10
{
    class Program
    // This program will display the patteren of right angle using asterisk.
    {
        static void Main(string[] args)
        {
            int a, b, rows;
            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle using asterisk:\n");
            Console.Write("\n\n");

            Console.Write("Input the number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= rows; a++)
            {
                for (b = 1; b <= a; b++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
