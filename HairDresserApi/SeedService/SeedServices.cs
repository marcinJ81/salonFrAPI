using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.SeedService
{
    public class SeedServices : ISeedService
    {
        private ISeedClient seedClient { get; set; }
        private ISeedServiceTable seedServiceTable { get; set; }
        private ISeedEmployee seedEmployee { get; set; }

        public SeedServices(ISeedClient sClient, ISeedServiceTable sServiceTable, ISeedEmployee sEmployee)
        {
            this.seedClient = sClient;
            this.seedServiceTable = sServiceTable;
            this.seedEmployee = sEmployee;
        }

        public void Seed()
        {
            seedClient.Seed();
            seedServiceTable.Seed();
            seedEmployee.Seed();
        }
    }
}
