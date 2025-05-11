using System;

namespace oops10inheritance{
    class vehicle{
        public string brand;

        public void setBrand(string Brand){
            this.brand = Brand;
        }

        public void honk(){
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class car : vehicle{
        public string model;

        public void setModel(string Model){
            this.model = Model;
        }
    }

    class Program{
        static void Main(string[] args){
            car mycar = new car();
            mycar.setBrand("Suzuki");
            mycar.setModel("Swift");
            mycar.honk();
            Console.WriteLine($"Brand: {mycar.brand}, Model: {mycar.model}");
        }
    }
}