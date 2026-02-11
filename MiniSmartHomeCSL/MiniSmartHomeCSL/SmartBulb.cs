using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSmartHomeLib
{
    internal class SmartBulb: SmartDevice
    {
        public int Brightness { get; private set; } // 0-100
      
        //public bool? IsPoweredOn { get; set; }

        public void SetBrightness(int brightness)
        {
            if(!Power.IsPoweredOn)
                throw new InvalidOperationException("" +
                    "Bulb must be powered on to adjust brightness.");


            if (brightness < 0 || brightness > 100)
                throw new ArgumentOutOfRangeException(nameof(brightness), 
                    "Brightness must be between 0 and 100.");
            
            Brightness = brightness;

        }

        public override string GetStatus()
        {
            return $"Bulb '{Name}' is {(Power.IsOnline ? "Online" : "Offline")}, " +
                $"Power: {(Power.IsPoweredOn ? "On" : "Off")}, " +
                $"Brightness: {Brightness}%";
        }
    }
}
