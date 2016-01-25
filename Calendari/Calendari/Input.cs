using PhidgetInteraction;
using System;
using System.Collections.Generic;

namespace Calendari
{
    class Input
    {
        private static InterPhi phi;

        public static void StartInput()
        {
            phi = new InterPhi();

            phi.AddSensor(new Sensor("0", "A", 400));
            phi.AddSensor(new Sensor("1", "D", 400));
            phi.AddSensor(new Sensor("2", "SPACE", 400));

            phi.StartPhidget();
        }

        public static void StartInput(List<Sensor> sensors)
        {
            phi = new InterPhi();

            foreach (Sensor s in sensors)
            {
                phi.AddSensor(s);
            }

            phi.StartPhidget();
        }

        public static bool GetInput(string id)
        {
            #if DEBUG
                Print();
            #endif
            return phi.GetValue(id);
        }

        public InterPhi Phidgets
        {
            get { return phi; }
            private set { phi = value; }
        }

        public static void Print()
        {
            foreach (Sensor s in phi.GetKeys())
            {
                if (s.Activated)
                    Console.WriteLine("Sensor {0} Value {1} RawValue {2}", s.Value, s.Activated, s.RawValue);
            }
        }

        public static bool GetState()
        {
            return phi.GetState();
        }

        public static List<Sensor> GetSensors()
        {
            return phi.sensors;
        }

        public static int GetRawValue(int sensor)
        {
            return GetSensors()[sensor].RawValue;
        }
    }
}
