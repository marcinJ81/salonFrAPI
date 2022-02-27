using HairDresserApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.SeedService
{
    public class SeedEmployee
    {
        private SalonDbContext dbContext { get; set; }

        public SeedEmployee(SalonDbContext context)
        {
            this.dbContext = context;
        }

        public bool Seed()
        {
            if (!dbContext.Database.CanConnect())
            {
                return false;
            }
            if (!dbContext.Employees.Any())
            {

                List<Employee> employees = new List<Employee>()
                {
                    new Employee { employee_name = "Marlenka", position = new Position { position_name = "pracownik" } },
                    new Employee{ employee_name = "Julian", position = new Position { position_name = "kierownik" } },
                    new Employee{ employee_name = "Skiper",position = new Position { position_name = "pracownik" }}
                };
                foreach (var i in employees)
                {
                    dbContext.Add(i);
                }
                dbContext.SaveChanges();
                return dbContext.Employees.Any();
            }

            return false;
        }
    }
}
