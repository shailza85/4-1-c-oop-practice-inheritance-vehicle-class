using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOOP
{
    /*
        Create a “Car” class that has the following properties:
        Make (Chevrolet, Nissan, Toyota)
        Model (Camry, Corolla, Cruze)
        Color (Red, Green, Blue, Black)
        Maximum Occupancy (Number of Seats)
        FuelEfficiency (Number of KM per Litre, can have decimals)
        Odometer - object reference
        FuelTank - object reference.
        and methods:
        Drive() and Drive(km) - call BurnFuel() and Increment() on the fuel tank and odometer, respectively, according to fuel efficiency.
        A ToString() override that will output the format “A Blue Chevy Cruze with 60050KM on the odometer, that has enough fuel to travel 65KM.”
        Both a default and greedy constructor (initialize object references as a new instance).
    */
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Seat[] Seats { get; set; }

        private Motor _motor;
        public Motor Motor
        {
            get
            {
                return _motor;
            }
            set
            {
                // See FuelTank.set for comments.
                if (_motor != null && _motor.Car == this)
                {
                    _motor.Car = null;
                }
                if (value.Car != this)
                {
                    value.Car = this;
                }

                _motor = value;
            }
        }

        private Odometer _odometer;
        public Odometer Odometer
        {
            get
            {
                return _odometer;
            }
            set
            {
                // See FuelTank.set for comments.
                if (_odometer != null && _odometer.Car == this)
                {
                    _odometer.Car = null;
                }
                if (value.Car != this)
                {
                    value.Car = this;
                }

                _odometer = value;
            }
        }

        private FuelTank _fuelTank;
        public FuelTank FuelTank
        {
            get
            {
                return _fuelTank;
            }
            set
            {
                // '_fuelTank' (before it is re-set) is the old fuel tank.
                // 'value' is the new fuel tank.
                // 'this' is the car.

                // Before we overwrite our fuel tank, make sure that the old fuel tank is no longer pointing to this car.
                if (_fuelTank != null && _fuelTank.Car == this)
                {
                    _fuelTank.Car = null;
                }

                // Set the new fuel tank to point to this car.                
                if (value.Car != this)
                {
                    value.Car = this;
                }

                // Actually assign the reference variable in this object.
                _fuelTank = value;
            }
        }

        public void Drive()
        {
            Drive(100);
        }

        public void Drive(int km)
        {
            Seats[0].Occupied = true;
            Odometer.Increment(km);
            FuelTank.BurnFuel(km / Motor.FuelEfficiency);
            Seats[0].Occupied = false;
        }

        public Car()
        {
            Make = "Toyota";
            Model = "Camry";
            Color = "Grey";
            // Create 5 seats as a default.
            Seats = new Seat[] { new Seat(true), new Seat(true), new Seat(), new Seat(), new Seat() };
            Motor = new Motor();
            Odometer = new Odometer();
            FuelTank = new FuelTank();
        }
        public Car(string make, string model, string color, int maxOccupancy)
        {
            Make = make;
            Model = model;
            Color = color;
            // Allow the max occupancy parameter to determine the number of seats.
            Seats = new Seat[maxOccupancy];
            for (int i = 1; i <= maxOccupancy; i++)
            {
                Seats[i] = new Seat();
            }
            Motor = new Motor();
            Odometer = new Odometer();
            FuelTank = new FuelTank();
        }

        public override string ToString()
        {
            // This uses LINQ, don't sweat it if it doesn't make sense just yet, was just answering Jia's question.
            return $"A {Color} {Make} {Model} with {Seats.Length} seats ({Seats.Count(x => x.Occupied == true)} of which {(Seats.Count(x => x.Occupied == true) == 1 ? "is" : "are")} occupied), with {Odometer} on the odometer, that has enough fuel to travel {FuelTank.Level * Motor.FuelEfficiency}KM.";
        }
    }
}