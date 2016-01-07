using PhidgetInteraction;
using System;

namespace Calendari
{
    class Input
    {
        private static InterPhi phi;

        public static void StartInput()
        {
            phi = new InterPhi();

            phi.AddSensor(new Sensor("0", "A", 900));
            phi.AddSensor(new Sensor("1", "D", 900));
            phi.AddSensor(new Sensor("2", "SPACE", 500));

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
                Console.WriteLine("Sensor {0} Value {1}", s.Value, s.Activated);
            }
        }

        public static bool GetState()
        {
            return phi.GetState();
        }
    }
}
