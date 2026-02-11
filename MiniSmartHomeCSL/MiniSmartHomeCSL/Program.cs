using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MiniSmartHomeLib;
{
    
}

namespace MiniSmartHomeCSL
{
    class Program
    {
        static void Main(string[] args)
        {

            SmartBulb bulb = new SmartBulb("bulb001", "Patio Bulb");


            bulb.Rename("Bedroom Light");

            bulb.SetOnline(true);
            bulb.TurnOn();

            bulb.SetBrightness(75);

            Console.WriteLine("Status after turning on....");
            Console.WriteLine(bulb.GetStatus());

            //Intentional error: try turning on while offline
            try
            {
                bulb.SetOnline(false);   // take it offline
                bulb.TurnOn();           // throw
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\n Caught intentional error....");
                Console.WriteLine(ex.Message);
            }

            // turn off this bulb for now
            bulb.TurnOff();

            Console.WriteLine("\nStatus after turning off....");
            Console.WriteLine(bulb.GetStatus());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
