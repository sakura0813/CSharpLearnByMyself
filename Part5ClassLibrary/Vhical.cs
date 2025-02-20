using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5ClassLibrary
{
    public interface IVehicle
    {
        abstract public void Run();
        abstract public void Stop();
        abstract public void Fill();
    }

    public abstract class Vehicle : IVehicle
    {
        public void Fill()
        {
            Console.WriteLine("Vehicle is filling");
        }

        abstract public void Run();
        public abstract void Stop();
        
    }
    public class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("car is running...");
        }
        public override void Stop()
        {
            Console.WriteLine("car is stoping");
        }
        public class Truck : Vehicle
        {
            public override void Run()
            {
                Console.WriteLine("truck is Running");
            }

            public override void Stop()
            {
                Console.WriteLine("truck is stopping...");
            }
        }
    }
}
