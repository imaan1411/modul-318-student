using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImanSbbApp
{
    class DisplayConnection
    {
        private string arrival;
        private string departure;
        private string time;
        private string platform;

        public DisplayConnection(string Arrival, string Departure, string Time, string Platform)
        {
            arrival = getFormattedDate(Arrival);
            departure = getFormattedDate(Departure);
            time = getFormattedTime(Time);
            platform = Platform;
        }

        public string Arrival
        {
            get
            {
                return arrival;
            }
            private set
            {
                arrival = value;
            }
        }

        public string Departure
        { 
            get
            {
                return departure; 
            }
            private set
            {
                departure = value; 
            }
        }

        public string Time
        {
            get
            {                
                return time;
            }
            private set
            {
                time = value;
            }
        }

        public string Platform
        {
            get
            {
                return platform;
            }
            private set
            {
                platform = value;
            }
        }

        private string getFormattedDate(string val)
        {
            DateTime d = new DateTime();
            DateTime.TryParse(val, out d);

            return d.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private string getFormattedTime(string time)
        {
            return time.Split('d')[1];
        }
    }
}
