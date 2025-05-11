using System;

namespace oops4{
    class Car{
        string model;

        //non parameterized constructor
        public Car(){
            model = "BMW";
        }

        //Parameterized constructor
        public Car(string modelName){
            model = modelName;
        }

        static void Main(string[] args){
            Car car = new Car("Aston Martin"); //calls the custom Parameterised we added
            Console.WriteLine("The model of the car is: " + car.model);
        }
    }

    //NOTE - Why does model = modelName; work without using this.model?

    // Reason:
    // It works because the parameter name (modelName) is different from the field name (model), so there’s no ambiguity.


}