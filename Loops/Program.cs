using System;

namespace Loops{
    class Program{
        static void Main(string[] args){
            //while 

            int i = 0;
            while (i < 5) {
                Console.WriteLine(i);
                i++;
            }

            //do while
            int j = 0;
            do {
                Console.WriteLine(j);
                i++;
            }while (i < 5);

            //for loop
            for(int k = 0; k<5; k++){
                Console.WriteLine(k);
            }

            //nested loops also exist.

            //foreach 
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string c in cars) {
                Console.WriteLine(c);
            }


            //you know break and continue.
        }
            
    }
}