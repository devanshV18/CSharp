using System;
using System.Text;

namespace practice{


    class Program{

        static int BinarySearch(int[] arr, int target){
            int left = 0;
            int right = arr.Length-1;

            while(left <= right){
                int mid = left + (right-left)/2;

                if(arr[mid] == target){
                    return mid;
                }

                if(target > arr[mid]){
                    left = mid+1;
                }

                if(target < arr[mid]){
                    right = mid-1;
                }
            }

            return -1;
        }

        static bool isPalindrome(string s){

            int n = s.Length;
            for(int i = 0; i<n/2; i++){
                if(s[i] != s[n-i-1]){
                    return false;
                }
            }
            return true;
        }

        static string reverseString(string s){

            char[] arr = s.ToCharArray();
            int n = arr.Length;

            for(int i = 0; i<n/2; i++){
                char temp = arr[i];
                arr[i] = arr[n-i-1];
                arr[n-i-1] = temp;
            }

            string reversed = new string(arr);
            return reversed;
        }

        

        static void reverseStringSB(string s){
            StringBuilder str = new StringBuilder();

            int n = s.Length;
            for(int i = n-1; i>=0; i--){
                str.Append(s[i]);
            }

            Console.WriteLine(str.ToString());
        }

        static int factorial(int n){
            if( n == 0 ){
                return 1;
            }

            return n * factorial(n-1);
        }

        static void fibIt(int n){
            int a = 0;
            int b = 1;

            for(int i = 0; i<n; i++){
                Console.WriteLine(a + " ");
                int next = a + b; 
                a = b;
                b = next;
            }
        }

        static int fibRec(int n){
            if( n <= 1){
                return n;
            }
            else{
                return fibRec(n-1) + fibRec(n-2);
            }
        }

        static bool isPalindrome(int num){
            int originalNumber = num; //only to check at the end
            int reversedNumber = 0;
            int remainder;

            while(num != 0){
                remainder = num % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                num = num / 10;
            }

            return originalNumber == reversedNumber;
        }

        static bool isPrime(int num){
            if(num <= 1){
                return false; //0 and 1 are not prime
            }

            for(int i = 2; i<=Math.Sqrt(num); i++){
                if(num % i == 0){
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args){

        }

    }
}