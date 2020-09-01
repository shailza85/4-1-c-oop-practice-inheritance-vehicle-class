using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class RunTimeCounter
    {
        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = DateTime.Now;
            }

        }
        private Airplane _airplane;
        public Airplane Airplane
        {
            get
            {
                return _airplane;
            }
            set
            {
                _airplane = value;
            }
        }

        private string _runTime;
        public string RunTime
        {
            get
            {
                return _runTime;
            }
            private set
            {
                
                if (value =="OFF")
                {
                    throw new Exception("Engine stopped!!");
                }
                else if(value=="ON")
                {
                    throw new Exception("Engine started!!");
                }
                else
                {
                    _runTime = value;
                }
              
            }
        }

        public RunTimeCounter()
        {
            
            Airplane.StartEngine();
            RunTime = "ON";
            Airplane.StopEngine();
            RunTime = "OFF";

        }
        public RunTimeCounter(int counter)
        {
            //RunTime = Date - DateTime.Now;
        }

        public void Increment(int count)
        {
           // RunTime= count++;
        }

        public override string ToString()
        {
            // return $"{RunTime:D6}"; <-- https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1
            return $"{RunTime.ToString().PadLeft(6, '0')}";
        }
    }
}