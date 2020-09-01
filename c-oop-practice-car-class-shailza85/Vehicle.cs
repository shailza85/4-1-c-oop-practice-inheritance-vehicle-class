using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public abstract class Vehicle
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
                    value.Car = (Car)this;
                }

                _motor = value;
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
                    value.Car = (Car)this;
                }

                // Actually assign the reference variable in this object.
                _fuelTank = value;
            }
        }
    }

}
