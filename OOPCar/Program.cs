using System;

namespace OOPCar
{
    class Car
    {
        string mark;
        string model;
        string regnumber;
        string color;
        string odo;
        string fueltank;

        public Car(string _mark, string _model, string _regnumber, string _color )
        {
            mark = _mark;
            model = _regnumber;
            color = _color;
            regnumber = _regnumber;
            odo = 0;
            fueltank = 60;

            Console.WriteLine($"{mark} {model} {regnumber} has been created");
        }


    }
        static void Main(string[] args)
        {
        Car myCar = new Car("Bmw", "E39 M3", "P0LEKSN");
        }
    }
}
