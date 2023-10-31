using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays");
            Console.WriteLine();

            char[,] emoticon;
            emoticon = new char[5, 5];

            emoticon[2, 0] = '*';
            emoticon[2, 4] = '*';
            emoticon[0, 2] = '*';
            emoticon[3, 3] = '*';
            emoticon[1, 1] = '*';
            emoticon[3, 1] = '*';
            emoticon[1, 3] = '*';
            emoticon[4, 2] = '*';

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(emoticon[x, y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
