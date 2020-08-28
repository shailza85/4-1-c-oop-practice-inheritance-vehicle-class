using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a car with a motor.
            Car myCar = new Car()
            {
                Make = "Who Knows",
                Model = "Badge Missing",
                Color = "Rusty",
                Motor = new Motor(4),
                Odometer = new Odometer(564291),
                FuelTank = new FuelTank()
            };

            // Point a variable at the old motor.
            Motor oldMotor = myCar.Motor;

            // Create a new motor.
            Motor newMotor = new Motor()
            {
                FuelEfficiency = 10
            };

            // TODO: Fix this:
            // This won't work because of the way we implemented referential integrity.
            // It will set the car of the motor, but not the motor of the car. So the car will effectively have newMotor as it's motor, and an orphan motor that thinks it's still in the car.
            oldMotor.Car = myCar;

            // Change the car's motor to the new motor.
            myCar.Motor = newMotor;

            // Referential integrity should make the car on old motor null.
            Console.WriteLine(oldMotor.Car == null ? "NULL" : oldMotor.Car.ToString());


        }

    }
}