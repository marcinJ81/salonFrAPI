using HairDresserApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.SeedService
{
    public class SeedClient : ISeedClient
    {
        private SalonDbContext dbContext { get; set; }

        public SeedClient(SalonDbContext context)
        {
            this.dbContext = context;
        }

        public bool Seed()
        {
            if (!dbContext.Database.CanConnect())
            {
                return false;
            }
            if (!dbContext.Clients.Any())
            {
                List<Client> clients = new List<Client>()
                {
                    new Client{ client_name = "marcin juranek", client_phone="12356",client_description="wiecznie niezadowlony"},
                    new Client{ client_name = "marcin", client_phone="1236",client_description="brak"}
                };
                foreach (var i in clients)
                {
                    dbContext.Add(i);
                }
                dbContext.SaveChanges();
                return dbContext.Clients.Any(x => x.client_name == clients[1].client_name);
            }

            return false;
        }
    }
}
