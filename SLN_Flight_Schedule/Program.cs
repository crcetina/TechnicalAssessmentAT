// See https://aka.ms/new-console-template for more information
using Flight_Schedule_APP;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#region Variables

List<Orders> lstOrder = new List<Orders>();
List<Itinerary> lstItin = new List<Itinerary>();
string Option = string.Empty;

#endregion



Console.WriteLine("-------------------FLIGHT SCHEDULE--------------------------");

do
{
    Console.WriteLine("-------------------MENU--------------------------");
    Console.WriteLine("");
    Console.WriteLine("1. Load flight schedule");
    Console.WriteLine("2. load the given orders");

    Console.WriteLine("Press e to exit");
    Option = Console.ReadLine();

    switch (Option)
    {
        case "1":
            lstItin = ItineraryBussines.GetInstance.itenerary();
            break;
        case "2":
            lstOrder = Common.GetInstance.LoadJson();
            OrderBussines.GetInstance.GetOrders(lstItin, lstOrder);

            break;
        default:
            break;
    }
} while (Option != "e");

Console.WriteLine("-------------------END FLIGHT SCHEDULE--------------------------");
























