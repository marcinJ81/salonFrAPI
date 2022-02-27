using HairDresserApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.SeedService
{
    public class SeedServiceTable
    {
        private SalonDbContext dbContext { get; set; }
        public SeedServiceTable(SalonDbContext context)
        {
            this.dbContext = context;
        }

        public bool Seed()
        { 
            
        }
    }
}
