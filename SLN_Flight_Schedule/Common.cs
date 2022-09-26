using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Flight_Schedule_APP
{
    public class Common
    {
        #region Singleton
        private static readonly Lazy<Common> UnicInstance = new Lazy<Common>(() => new Common());
        public static Common GetInstance
        {
            get
            {
                return UnicInstance.Value;
            }
        }
        #endregion


        public List<Orders> LoadJson()
        {
            List<Orders> lstOrder = new List<Orders>();
            string json = string.Empty;
            using (StreamReader r = new StreamReader("coding-assigment-orders.json"))
            {
                json = r.ReadToEnd();
            }

            var lstOrders = JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var item in lstOrders)
            {
                lstOrder.Add(new Orders()
                {
                    NumOrder = item.Name,
                    destination = item.Value.destination
                });
            }

            return lstOrder;
        }
    }
}
