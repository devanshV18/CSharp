using System;

namespace oops2{
    class Car{
        string color = "red"; //can be set using . also inside svm 
        int maxSpeed = 170; //can be set using . also inside svm

        public void printSpecs(){
            Console.WriteLine($"The color if the car is {color} and the max speed is {maxSpeed}.");
        }

        static void Main(string[] args){
            Car myCar = new Car();
            myCar.printSpecs();
        }
    }
}