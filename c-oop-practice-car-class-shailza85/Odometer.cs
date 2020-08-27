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
                    temp = value + 999999;
                    temp1 = temp - 100000;
                    _counter = temp1;
                }

                else
                {
                    _counter = value;
                }
               
               /* if (value > 999999)
                {
                    temp = value - 999999;
                }
                _counter = temp;*/
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
