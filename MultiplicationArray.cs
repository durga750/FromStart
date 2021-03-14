using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MultiplicationArray
    {
        static void Main(string[] args)
        {
           // int[,] a = { { 1, 2 }, { 3, 4 } }; //other type of Declaration
            int[,] a = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] b = new int[,] { { 3, 4 }, { 2, 1 } };

            int m = 2, n = 2, p = 2, q = 2;
            Console.WriteLine("Multiplication of two matrixs is:");
            if(n!=p)
            {
                Console.WriteLine("multiplication is not Possible");

            }
            else
            {
                int[,] c = new int[m, q];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < q; j++)
                    {
                        c[i, j] = 0;

                        for (int k = 0; k < n; k++)
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
}
