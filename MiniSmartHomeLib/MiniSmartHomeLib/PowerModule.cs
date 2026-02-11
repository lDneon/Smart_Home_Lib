namespace MiniSmartHomeLib
{
    public class PowerModule
    {
        public bool IsOnline { get; private set; }
        public bool IsPoweredOn {get; private set;}


        public void SetOline(bool online)
                    {
            IsOnline = online;
        }

        public void TurnOn ()
        {
               if (!IsOnline)
                  throw new InvalidOperationException("Device must be online to power on.");


        }

        public void TurnOff()
        {
            if (!IsOnline)
                IsPoweredOn = false;
                
        }


    }
}
