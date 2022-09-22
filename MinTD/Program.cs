using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinTD
{
    internal class Program
    {
        public static void minelement(int no_of_rows, int[][] arr)
        {
            int i = 0;
            int min = 0;

            int[] result = new int[no_of_rows];

            while (i < no_of_rows)

            {

                for (int j = 0;

                         j < arr[i].Length; j++)

                {

                    if (arr[i][j]<min)

                    {

                        min = arr[i][j];

                    }

                }

                result[i] = min;

                min =0;

                i++;


            }
            printArray(result);
        }

        private static void printArray(int[] result)
        {

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
        public static void Main(string[] args)
        {

            int[][] arr = new int[][]
            {
                new int[] {3, 4, 1, 8},

                 new int[] {17, 4, 9, 11},

                 new int[] {76, 3, 21, 1},
            };
            minelement(3,arr);
        }

    }
}
