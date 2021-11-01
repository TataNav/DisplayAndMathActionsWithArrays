using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC_coding_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = CreateArray(4, 4, -11, 15);
            Console.WriteLine("Matrix");
            Print(arr);
            
            int[] diagonal = GetDiagonal(arr);
            Console.WriteLine("Digonal");
            Print(diagonal);

            Console.WriteLine();

            int maxOfArray = GetMax(arr);
            Print("The maximum element of the array", maxOfArray);
            int maxOfDiagonal = GetMax(diagonal);
            Print("The maximum element of the diagonal", maxOfDiagonal);
            int[] maxValuePosition = GetPositionOfMax(arr);
            Console.WriteLine("Max value position");
            Print(maxValuePosition);

            Console.ReadKey();
        }

        ///<summary>
        ///Randomly generates a multidimensional array in between specified range.
        ///</summary>
        ///<param name="rows">Number of rows in the array</param>
        ///<param name="columns">Number of columns in the array</param>
        ///<param name="lowerBound">The min that array element can be</param>
        ///<param name="upperBound">The max that array element can be</param>
        ///<returns>Random multidimnesional array</returns>
        public static int[,] CreateArray(int rows, int columns, int lowerBound, int upperBound)
        {
            Random random = new Random();
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(lowerBound, upperBound);
                }
            }

            return array;
        }
        ///<summary>
        ///Prints a multidimensional array.
        ///</summary>
        ///<param name="array">The array that should be printed</param>
        public static void Print(int[,] array)
        {
            int arrayLength = array.GetLength(0);
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        ///<summary>
        ///Prints an array.
        ///</summary>
        ///<param name="array">The array that should be printed.</param>
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        ///<summary>
        ///Prints the given message with the given value included.
        ///</summary>
        ///<param name="message">The word or sentence to be printed.</param>
        ///<param name="value">The value that should to be printed.</param>
        public static void Print(String message, int value)
        {
            Console.WriteLine($"{message} {value}.");
        }
        ///<summary>
        ///Puts diagonal elements into an array.
        ///</summary>
        ///<param name="array">An input array to get diagonal elements from.</param>
        ///<returns>Returns a single dimensional array</returns>
        public static int[] GetDiagonal(int[,] array)
        {
            int arrayLength = array.GetLength(0);
            int[] diagonal = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                diagonal[i] = array[i, i];
            }

            return diagonal;
        }
        ///<summary>
        ///Finds the max value in the given array.
        ///</summary>
        ///<param name="array">An input array to get the max value from.</param>
        ///<returns>Returns the max value of the array.</returns>
        public static int GetMax(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        ///<summary>
        ///Finds the max value in the given multidimensional array.
        ///</summary>
        ///<param name="array">An input array to get the max value from.</param>
        ///<returns>Returns the max value of the array.</returns>
        public static int GetMax(int[,] array)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[i,j] > max)
                    {
                        max = array[i,j];
                    }
                }
            }
            return max;
        }
        ///<summary>
        ///Finds the position of the max value in the given array.
        ///</summary>
        ///<param name="array">An input array to get the max value position from.</param>
        ///<returns>Returns the max value position in the array.</returns>
        public static int[] GetPositionOfMax(int[,] array)
        {
            int[] position = new int[array.Rank];
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return position;
        }
    }
}
