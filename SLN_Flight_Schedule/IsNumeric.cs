using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Schedule_APP
{
    internal class IsNumeric
    {
        #region Singleton
        private static readonly Lazy<IsNumeric> UnicInstance = new Lazy<IsNumeric>(() => new IsNumeric());
        public static IsNumeric GetInstance
        {
            get
            {
                return UnicInstance.Value;
            }
        }
        #endregion

        public bool IsNumeric1(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
