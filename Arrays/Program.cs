using System;
ujsing System.Linq;

namespace Arrays{
    class Program{
        static void Main(string[] args){

        // Create an array of four elements, and add values later
        string[] cars = new string[4];

        // Create an array of four elements and add values right away 
        string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements without specifying the size 
        string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        }

        //looping can be done using normal for loop and foreach function. Length property comes with arrays
        //index start from 0 , we can obviously use negativ/positivee indexing to get the element of the array as in other languages.

        //some demos

        //sorting an array of nums in ascending order
        int [] nums = {1,7,2,17,-3};
        Arrays.Sort(nums);
        for(int i = 0; i<nums.Length; i++){
            Console.WriteLine(nums[i]);
        }

        string[] vehicles = {"Volvo", "BMW", "Ford", "Mazda"};
        Array.Sort(vehicles);
        foreach (string vehicle in vehicles) {
            Console.WriteLine(vehicle);
        }

        //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

        int[] myNumbers = {5, 1, 8, 9};
        Console.WriteLine(myNumbers.Max());  // returns the largest value
        Console.WriteLine(myNumbers.Min());  // returns the smallest value
        Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
}