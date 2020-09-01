using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    //public DateTime? StartAt { get; set; }
    //public DateTime? StartAt { get; set; }

    //public RunTimeCounter Date;
    public class Airplane: Vehicle
    {
        /*
         * When “Stop Engine” is run, add to the RunTimeCounter RunTime property equal to the time since the engine was last started. Use the DateTime object and 
         * a private property in RunTimeCounter to keep track of when the engine was started.
          * If the engine is stopped while off, or started while on, throw an exception.

         */

        private RunTimeCounter _runTime;
        public RunTimeCounter RunTime
        {
            get
            {
                return _runTime;
            }
            set
            {
                // See FuelTank.set for comments.
                if (_runTime != null && _runTime.Airplane == this)
                {
                    _runTime.Airplane = null;
                }
                if (value.Airplane != this)
                {
                    value.Airplane = this;
                }

                _runTime = value;
            }
        }
        public void StartEngine()
        {
            RunTime.Date= DateTime.Now; 
        }

        public void StopEngine ()
        {
            RunTime.Date = DateTime.Now;

        }
          
    }
}
