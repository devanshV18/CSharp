using System;

namespace MultidimensionalArrays{
    class Program{
        static void Main(string[] args){
            // Multidimensional arrays
            //single comma - 2d array
            //multiaArray is an array wit 2 arraysa s its elements.
            int[,] multiArray = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }};

            // Accessing elements
            Console.WriteLine("Element at (0,0): " + multiArray[0, 0]);
            Console.WriteLine("Element at (1,2): " + multiArray[1, 2]);

            // Iterating through the array
            for (int i = 0; i < multiArray.GetLength(0); i++) {
                for (int j = 0; j < multiArray.GetLength(1); j++) {
                    Console.Write(multiArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}