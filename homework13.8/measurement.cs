using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework13._8
{
    public class Measurement
    {
        public string location;
        public int day;
        public double temparture;

        public Measurement(string location, int day, double temparture)
        {
            this.location = location;
            this.day = day;
            this.temparture = temparture;
        }
    }

}
