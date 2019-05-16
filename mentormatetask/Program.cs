using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentormatetask
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Въведете нечетно число(от 2 до 10000 за дебелина на М:");
            int n = int.Parse(Console.ReadLine());
            char[,] A = new char[n+1,5*n]; 
            Console.WriteLine();

            for (int i = 0; i <= n; i++)
                for (int j = 0; j < 5 * n; j++)
                    A[i,j] = '-';

            int m = n;
            bool change = true;
            for (int i =0; i<=4*n;i++)
            {
                for (int j = i; j < n + i; j++)
                    A[m, j] = '*';
                if (m == 0) change = false;
                if (m == n) change = true;
                    if (change == true) m--;
                    else m++;
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 5 * n; j++)
                    Console.Write(A[i, j]);
                for (int j = 0; j < 5 * n; j++)
                    Console.Write(A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
