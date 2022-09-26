using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Schedule_APP
{
    public class OrderBussines
    {
        #region Singleton
        private static readonly Lazy<OrderBussines> UnicInstance = new Lazy<OrderBussines>(() => new OrderBussines());
        public static OrderBussines GetInstance
        {
            get
            {
                return UnicInstance.Value;
            }
        }
        #endregion

        public List<Itinerary> GetOrders(List<Itinerary> lstItin, List<Orders> lstOrder)
        {
            List<Itinerary> NewlstItin = new List<Itinerary>();
            string Option = string.Empty;
            try
            {
                foreach (var ord in lstOrder)
                {
                    int countRow = NewlstItin.Where(x => x.Arrival.Equals(ord.destination)).Count();
                    string dayFlight = countRow > 19 ? "2" : "1";

                    Itinerary Objtinerary = lstItin.Where(x => x.Arrival.Equals(ord?.destination) && x.DayFlight.Equals(dayFlight)).FirstOrDefault();

                    if (Objtinerary != null)
                    {
                        NewlstItin.Add(new Itinerary()
                        {
                            Arrival = Objtinerary.Arrival,
                            DayFlight = dayFlight.ToString(),
                            Departure = Objtinerary.Departure,
                            FligthNumber = Objtinerary.FligthNumber,
                            Order = ord.NumOrder
                        });
                    }
                    else
                    {
                        NewlstItin.Add(new Itinerary()
                        {
                            Arrival = String.Empty,
                            DayFlight = String.Empty,
                            Departure = String.Empty,
                            FligthNumber = "not scheduled",
                            Order = ord.NumOrder
                        });
                    }

                    

                }

                /////////////PRINT flight schedule
                Console.WriteLine("for List out the loaded the given orders press l");
                Option = Console.ReadLine();

                if (Option.Equals("l") || Option.Equals("L"))
                {
                    foreach (var item in NewlstItin)
                    {
                        Console.WriteLine("Order: " + item.Order + ", Flight: " + item.FligthNumber + ", departure: " + item.Departure + ", arrival: " + item.Arrival + ", day: " + item.DayFlight);
                    }

                }
            }
            catch (Exception EX)
            {

                throw;
            }




            return NewlstItin;
        }
    }
}
