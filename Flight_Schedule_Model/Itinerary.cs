using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Itinerary
    {
        public int Id { get; set; }
        public string Order { get; set; }
        public string FligthNumber { get; set; }
        public string Departure { get; set; }

        public string Arrival { get; set; }

        public string DayFlight { get; set; }
    }
}
