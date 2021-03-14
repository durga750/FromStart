using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MulArrayOtherway
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 3, 4 }, { 2, 1 } };
            int[,] c = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                    Console.Write(c[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
