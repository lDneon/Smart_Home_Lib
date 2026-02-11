using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSmartHomeLib
{
    internal class SmartDevice
    {
        public string Device_Id { get; }
        public string Name { get; private set; }
        public PowerModule Power { get; }

        public void Rename(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("Name cannot be blank.", nameof(newName));
            Name = newName;

        }

        public virtual void SetOnline(bool online)
        {
            Power.SetOline(online);
        }

        public virtual void TurnOn()
        {
            Power.TurnOn();
        }
        public virtual void TurnOff()
        {
            Power.TurnOff();
        }

        public abstract string GetStatus();
    }
}
