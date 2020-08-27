using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_car_class_shailza85
{
    public class Odometer
    {

        private int _counter;
        private int temp;
        private int temp1;
        public int Counter {
            get
            {

                return _counter; 
            }

            private set
            {
                if (value > 999999) 
                { 
                    value -= 999999; 
                    _counter = value;
                }
              

            }
        }

        public Odometer()
        {
            Counter = 0;
        }

        public void Increment (int count)
        {
            Counter += count;
        }

    }
}
