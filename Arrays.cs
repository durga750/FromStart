using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 2, 1 }, { 4, 3 } };
            int[,]c= new int[2,2];
            Console.WriteLine("First Array is:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Second Array is:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("addition of two Array is:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write( c[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
