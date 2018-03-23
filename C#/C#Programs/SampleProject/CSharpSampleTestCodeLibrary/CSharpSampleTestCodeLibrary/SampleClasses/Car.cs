using System;

namespace CSharpSampleTestCodeLibrary.SampleClasses
{
    public class Car
    {
        // Field Data aka member variable
        public string carName;
        public int carTopSpeed;
        public bool engineSwitchStatus;

        public bool StartEngine(bool engineSwitch)
        {
            engineSwitchStatus = engineSwitch;
            if (engineSwitchStatus)
            {
                Console.WriteLine("Car engine has started.. :-)");
            }
            else
            {
                Console.WriteLine("Car engine is off.");
                
            }

            Console.Read();
            return engineSwitchStatus;
        }
    }
}
