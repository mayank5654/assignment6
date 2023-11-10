using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declare and Initialize Jagged Array of Integers
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 4, 7, 6, 3 };
            matrix[1] = new int[] { 6, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            // Task 2.1: Access and store the value of the second element in the first row
            int element = matrix[0][1];
            Console.WriteLine($"Value of the second element in the first row: {element}");
            // Task 2.2: Display the entire matrix using nested loop
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }

            // Task 3.1: Modify the third element in the second row
            if (matrix.Length > 1 && matrix[1].Length > 2)
            {
                matrix[1][2] = 15;
                Console.WriteLine("Modification successful.");
            }
            else
            {
                Console.WriteLine("Cannot modify the third element in the second row. Insufficient elements.");
            }

            // Task 4.1: Declare and Initialize Jagged Array of Objects
            object[][] objectMatrix = new object[2][];
            objectMatrix[0] = new object[] { 10, "Hello", 3.14 };
            objectMatrix[1] = new object[] { true, 'A', DateTime.Now };

            // Task 4.2: Display the contents of the objectMatrix
            Console.WriteLine("\nObject Matrix:");
            for (int i = 0; i < objectMatrix.Length; i++)
            {
                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    Console.WriteLine($"Type: {objectMatrix[i][j].GetType().Name}, Value: {objectMatrix[i][j]}");
                }
            }
            Console.ReadKey();
        }
    }
}