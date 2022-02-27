using HairDresserApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.SeedService
{
    public class SeedServiceTable : ISeedServiceTable
    {
        private SalonDbContext dbContext { get; set; }
        public SeedServiceTable(SalonDbContext context)
        {
            this.dbContext = context;
        }

        public bool Seed()
        {
            if (!dbContext.Database.CanConnect())
            {
                return false;
            }
            if (!dbContext.ServiceTables.Any())
            {
                List<ServiceTable> service = new List<ServiceTable>()
                {
                  new ServiceTable{ service_name = "strzyżenie", service_price = 20},
                  new ServiceTable{ service_name = "trwała", service_price = 40}
                };
                foreach (var i in service)
                {
                    dbContext.Add(i);
                }
                dbContext.SaveChanges();
                return dbContext.ServiceTables.Any();
            }
            return false;
        }
    }
}
