using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Schedule_APP
{
    public class ItineraryBussines
    {
        #region Singleton
        private static readonly Lazy<ItineraryBussines> UnicInstance = new Lazy<ItineraryBussines>(() => new ItineraryBussines());
        public static ItineraryBussines GetInstance
        {
            get
            {
                return UnicInstance.Value;
            }
        }
        #endregion


        public List<Itinerary> itenerary()
        {
            List<Itinerary> lstItin = new List<Itinerary>();
            string NumDays = string.Empty;
            string NumPlanes = string.Empty;
            string FlightNum = string.Empty;
            string Option = string.Empty;
            string Departure = string.Empty;
            string Arrival = string.Empty;
            string DayFlight = string.Empty;
            bool dummy = true;

            if (dummy)
            {
                Itinerary obj1 = null;
                obj1 = new Itinerary() { Id = 1, FligthNumber = "1", Departure = "YUL", Arrival = "YYZ", DayFlight = "1" };
                lstItin.Add(obj1);
                obj1 = new Itinerary() { Id = 2, FligthNumber = "2", Departure = "YUL", Arrival = "YYC", DayFlight = "1" };
                lstItin.Add(obj1);
                obj1 = new Itinerary() { Id = 3, FligthNumber = "3", Departure = "YUL", Arrival = "YVR", DayFlight = "1" };
                lstItin.Add(obj1);
                obj1 = new Itinerary() { Id = 4, FligthNumber = "4", Departure = "YUL", Arrival = "YYZ", DayFlight = "2" };
                lstItin.Add(obj1);
                obj1 = new Itinerary() { Id = 5, FligthNumber = "5", Departure = "YUL", Arrival = "YYC", DayFlight = "2" };
                lstItin.Add(obj1);
                obj1 = new Itinerary() { Id = 6, FligthNumber = "6", Departure = "YUL", Arrival = "YVR", DayFlight = "2" };
                lstItin.Add(obj1);
                foreach (var item in lstItin)
                {
                    Console.WriteLine("Flight: " + item.Id + ", departure: " + item.Departure + ", arrival: " + item.Arrival + ", day: " + item.DayFlight);
                }

            }
            else
            {
                do
                {
                    Console.WriteLine("Please insert a valid number of days.");
                    NumDays = Console.ReadLine();

                } while (!IsNumeric.GetInstance.IsNumeric1(NumDays));


                do
                {
                    Console.WriteLine("Please insert a valid number of planes per day.");
                    NumPlanes = Console.ReadLine();

                } while (!IsNumeric.GetInstance.IsNumeric1(NumPlanes));


                for (int i = 0; i < Convert.ToInt32(NumDays); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(NumPlanes); j++)
                    {
                        Console.WriteLine("Press l for list City an code.");
                        Option = Console.ReadLine();

                        if (Option.Equals("l") || Option.Equals("L"))
                        {
                            Console.WriteLine("Montreal(YUL)");
                            Console.WriteLine("Toronto(YYZ)");
                            Console.WriteLine("Calgary(YYC)");
                            Console.WriteLine("Vancouver(YVR)");
                        }

                        Console.WriteLine("Please insert code airport departure");
                        Departure = Console.ReadLine();

                        Console.WriteLine("Please insert code airport arrival");
                        Arrival = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Please insert a valid Day flight.");
                            DayFlight = Console.ReadLine();

                        } while (!IsNumeric.GetInstance.IsNumeric1(DayFlight));

                        lstItin.Add(new Itinerary()
                        {
                            Id = lstItin.Count + 1,
                            FligthNumber = Convert.ToString(lstItin.Count + 1),
                            Arrival = Arrival,
                            Departure = Departure,
                            DayFlight = DayFlight
                        }); ;


                    }
                }


                /////////////PRINT flight schedule
                Console.WriteLine("for list out the loaded flight schedule press l");
                Option = Console.ReadLine();

                if (Option.Equals("l") || Option.Equals("L"))
                {
                    foreach (var item in lstItin)
                    {
                        Console.WriteLine("Flight: " + item.Id + ", departure: " + item.Departure + ", arrival: " + item.Arrival + ", day: " + item.DayFlight);
                    }

                }
            }

            return lstItin;
        }
    }
}
