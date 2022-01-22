using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab21
{
    class Program
    {
        static int n = 10;
        static int[,] array = new int[n, n];
        static void Count1()
        {
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    int j = 0;
                    for (j = 0; j < n; j++)
                    {
                        if (array[i, j] != 2)
                        {
                            array[i, j] = 1;
                        }
                    }
                }
                else
                {
                    int j = 0;
                    for (j = n - 1; j >= 0; j = j - 1)
                    {
                        if (array[i, j] != 2)
                        {
                            array[i, j] = 1;
                        }
                    }

                }
            }
        }
        static void Count2()
        {
            for (int i = n - 1; i >= 0; i = i - 1)
            {
                if (n % 2 == 0)
                {
                    if ((i+1) % 2 == 0)
                    {
                        int j = 0;
                        for (j = n - 1; j >= 0; j = j - 1)
                        {
                            if (array[j, i] != 1)
                            {
                                array[j, i] = 2;
                            }
                        }
                    }
                    else
                    {
                        int j = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (array[j, i] != 1)
                            {
                                array[j, i] = 2;
                            }
                        }

                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        int j = 0;
                        for (j = n - 1; j >= 0; j = j - 1)
                        {
                            if (array[j, i] != 1)
                            {
                                array[j, i] = 2;
                            }
                        }
                    }
                    else
                    {
                        int j = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (array[j, i] != 1)
                            {
                                array[j, i] = 2;
                            }
                        }

                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ThreadStart t = new ThreadStart(Count2);
            Thread thread = new Thread(t);
            thread.Start();
            Count1();
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
