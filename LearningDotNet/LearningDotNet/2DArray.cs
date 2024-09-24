using System;
namespace LearningDotNet
{
    class TwoDArray
    {
        static int[,] initialize2DArray(int rowsize, int colsize)
        {
            int[,] arr = new int[rowsize, colsize];
            for (int i = 0; i < rowsize; i++)
                for (int j = 0; j < colsize; j++)
                {
                    Console.WriteLine("Enter (" + i + "," + j + ") Value:");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            return arr;
        }
        // ----------------------------------------------------------------------
        static void display2D(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        // --------------------------------------------------------------------
        static bool is_even(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }
        // --------------------------------------------------------------------
        static int[,] addition(int[,] a, int[,] b)
        {
            int[,] sum = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (is_even(a[i, j]) && is_even(b[i, j]))
                    {
                        sum[i, j] = a[i, j] + b[i, j];
                    }
                    else
                    {
                        setZeroResult(i, j, ref sum);
                    }

                }
            }
                return sum;
        }
            // --------------------------------------------------------------------
            static void setZeroResult(int i, int j, ref int[,] a)
            {
                a[i, j] = 0;
            }
            // --------------------------------------------------------------------
        public static void Main(string[] args)
            {
                Console.WriteLine("Addition of two Array (if Even, else ZERO):");
                Console.WriteLine("Enter row size:");
                int rowsize = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Column size:");
                int colsize = int.Parse(Console.ReadLine());
                int[,] a = initialize2DArray(rowsize, colsize);
                int[,] b = initialize2DArray(rowsize, colsize);
                int[,] c = addition(a, b);
                display2D(c);

                //display2D(a);
                //Console.WriteLine(is_even(2));
                //Console.WriteLine(is_even(3));

            }
        }
    }