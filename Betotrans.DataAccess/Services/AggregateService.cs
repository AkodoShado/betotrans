using System;
using System.Collections.Generic;
using System.Linq;

namespace Betotrans.DataAccess.Services
{
    public class AggregateService
    {
        public Aggregate Get(string name)
        {
            using (var dbContext = new BetotransDbEntities())
            {
                return dbContext.Aggregate.First(a => a.AggregateName.Equals(name, StringComparison.InvariantCultureIgnoreCase));
            }
        }
    }
}
