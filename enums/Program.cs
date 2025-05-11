using System;

namespace enums{

    enum Status
    {
        Pending,
        Approved,
        Rejected
    }

    //custom starting values
    enum ErrorCode{
    None = 0,
    Unknown = 100,
    ConnectionLost = 101,
    OutOfMemory = 102
    }

    enum TrafficLight { Red, Yellow, Green }


    //By efault , Pending - 0. Approved - 1, Rejected - 2
    class Program{
        static void Main(string[] args){
            Status current = Status.Approved;
            Console.WriteLine(current); //Approved
            Console.WriteLine((int)current); // 1

            //enums with switch case

            TrafficLight light = TrafficLight.Yellow;
            Console.WriteLine(light); //yellow

            switch (light){
                case TrafficLight.Red:
                    Console.WriteLine("Stop");
                    break;

                case TrafficLight.Yellow:
                    Console.WriteLine("ready");
                    break;

                case TrafficLight.Green:
                    Console.WriteLine("Green");
                    break;
            }


        }
    }
}