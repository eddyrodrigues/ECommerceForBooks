using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceForBooksCatalog.Application
{
    internal class SpreadService : ISpreadService
    {
        public decimal GetSpreadValue(DateTime dateTime)
        {
            if (dateTime.Equals(DateTime.MinValue))
            {
                return 0.10M;
            }

            return 0.20M;
        }
    }
}
