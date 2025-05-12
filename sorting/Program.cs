using System;

namespace sorting{
    class program{
        public static void BubbleSort(int[] arr){
            int n = arr.Length;

            for(int i = 0; i<n-1; i++){
                for(int j = 0; j<n-i-1; j++){
                    if(arr[j] > arr[j+1]){
                        //swap
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr){
            int n = arr.Length;

            for(int i = 0; i<n-1; i++){
                int minIndex = i;

                for(int j = i+1; j<n; j++){
                    if(arr[j] < arr[minIndex]){
                        minIndex = j;
                    }
                }

                if(minIndex != i){
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(numbers);

            SelectionSort(numbers);

            Console.WriteLine("Sorted array:");
            PrintArray(numbers);
        }
    }
}