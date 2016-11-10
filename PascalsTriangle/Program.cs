using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                usage();
                return;
            }
            int N = Int32.Parse(args[0]);

            int[] tri = new int[N];

            for (int pass = 0; pass < N; pass++)
            {
                tri[pass] = 1;

                // calc from previous
                int x = pass - 1;
                while (x > 0)
                {
                    int prev = tri[x] + tri[x - 1];
                    tri[x] = prev;
                    x--;
                }
                outTriangle(tri, pass + 1, N);
            }
            System.Console.ReadLine();
        }

        static void outTriangle(int[] triangle, int len, int N)
        {
            // space padding at start
            int aprox = (N * 4 / 2) - (len);
            for (int j = 0; j < aprox; j++)
                System.Console.Write(" ");


            for (int i = 0; i < len; i++)
            {
                System.Console.Write("{0} ", triangle[i]);
            }
            System.Console.WriteLine();
        }

        static void usage()
        {
            System.Console.WriteLine("PascalsTriangle <Number of Rows>");
            System.Console.ReadLine();
        }
    }
}
