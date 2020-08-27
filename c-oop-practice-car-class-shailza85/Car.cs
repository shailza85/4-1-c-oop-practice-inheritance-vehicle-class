using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_car_class_shailza85
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int MaxOccupancy { get; set; }

        public double FeulEfficiency { get; set; }

        public Odometer Counter1 { get; set; }
        public FeulTank Level1 { get; set; }

        /* Create a “Car” class that has the following properties:
Make (Chevrolet, Nissan, Toyota)
Model (Camry, Corolla, Cruze)
Color (Red, Green, Blue, Black)
Maximum Occupancy (Number of Seats)
FuelEfficiency (Number of KM per Litre, can have decimals)
Odometer - object reference
FuelTank - object reference.

         * 
         */
        public Car()
        {
            Make = "Toyota";
            Model = "Corolla";
            Color = "Red";
            MaxOccupancy = 3;
            FeulEfficiency = 5.5;
            Counter1= new Odometer();
            Level1 = new FeulTank();

                    }
        /*
         * Drive() and Drive(km) - call BurnFuel() and Increment() on the fuel tank and 
         * odometer, respectively, according to fuel efficiency.*/
         
        public void Drive()
        {
            Counter1.Increment(999999);
            Level1.BurnFeul(20);
        }

        public void Drive(int Km)
        {
            int kilometer = Km;
            Counter1.Increment(kilometer);
            Level1.BurnFeul(20);
        }

        public override string ToString()
        {
            return $"This is a {Make} {Model} {Color} with {Counter1.Counter}KM on the odometer, that has feul capacity {Level1.Level}";
        }
    }
}
