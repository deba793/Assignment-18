using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        private bool isConnected;
        private int batteryLevel;
        private string displayInfo;

        public Laptop()
        {

            isConnected = false;
            batteryLevel = 0;
            displayInfo = "Laptop display information...It's working well";
        }

        public bool Connect()
        {
            isConnected = true;
            return isConnected;
        }


        public void Charge(int minutes)
        {
            batteryLevel += (minutes * 2);
        }


        public string Display()
        {
            return displayInfo;
        }

        public int BatteryLevel
        {
            get { return batteryLevel; }
        }
    }


}