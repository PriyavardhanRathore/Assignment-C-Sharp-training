using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int row, column;

                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            Console.ReadLine();
        }
    }
}
