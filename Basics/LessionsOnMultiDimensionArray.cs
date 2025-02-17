using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class LessionsOnMultiDimensionArray
    {
        public void MultiDimensionArrayExample()
        {

        }

        public void MultiDimensionArrayExample1()
        {
            Console.WriteLine("Eter the number of rows and columns");
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("enter the input for Number at index " + i + " " + j + " is ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void MultiDimensionFindSmallest()
        {
            Console.WriteLine("Eter the number of rows and columns");
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];
            int smallest = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("enter the input for Number at index " + i + " " + j + " is ");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                    if (i == 0 && j == 0)
                    {
                        smallest = matrix[i, j];
                    }

                    if (smallest > matrix[i, j])
                    {
                        smallest = matrix[i, j];
                    }
                }
                Console.WriteLine();
            }

            //int smallest = matrix[0, 0];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (smallest> matrix[i,j])
            //        {
            //            smallest = matrix[i, j];
            //        }

            //    }

            //}
            Console.WriteLine("Smallest " + smallest);
        }

        public void ExampleOfJaggedArray()
        {
            //int [,] matrix = new int[3, 3];

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3] { 1, 2, 3 };
            jaggedArray[1] = new int[2] { 4, 5 };
            jaggedArray[2] = new int[4] { 6, 7, 8, 9 };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void ExampleOfImplictArray()
        {
            var matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

// Wrtie the following code in Program.cs , Add two matrixs and display the results
// Write a program to find the biggest in array
// Write a program to add two matrixs and display the results
