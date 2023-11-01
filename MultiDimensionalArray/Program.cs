using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        //static int loopVar = 3;
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static void DisplayMap(int scale)
        {
            Console.Write('+');
            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int z = 0; z < scale; z++)
                {
                    Console.Write('-');
                }
            }
            Console.Write('+');
            Console.WriteLine();
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int c = 0; c < scale; c++)
                {
                    Console.Write('|');
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        for (int z = 0; z < scale; z++)
                        {
                            Console.Write(map[y, x]);
                        }
                    }
                    Console.Write('|');
                    Console.WriteLine();
                }
            }
            Console.Write('+');
            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int z = 0; z < scale; z++)
                {
                    Console.Write('-');
                }
            }
            Console.Write('+');

            Console.WriteLine();
            Console.WriteLine();
        }

        static void DisplayMap()
        {
            Console.Write('+');
            for (int i = 0; i < map.GetLength(1); i++)
            {
                    Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine();
            for (int y = 0; y < map.GetLength(0); y++)
            {
                    Console.Write('|');
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                            Console.Write(map[y, x]);
                    }
                    Console.Write('|');
                    Console.WriteLine();
            }
            Console.Write('+');
            for (int i = 0; i < map.GetLength(1); i++)
            {
                    Console.Write('-');
            }
            Console.Write('+');

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DisplayMap();
            DisplayMap(1);
            DisplayMap(2);
            DisplayMap(3);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
