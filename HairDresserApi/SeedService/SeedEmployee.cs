using HairDresserApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.SeedService
{
    public class SeedEmployee : ISeedEmployee
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
                List<Position> positions = new List<Position>()
                {
                  new Position{position_name = "Kierownik" },
                  new Position{ position_name = "Pracownik"}
                };
                foreach (var i in positions)
                {
                    dbContext.Add(i);
                }
                dbContext.SaveChanges();

                List<Employee> employees = new List<Employee>()
                {
                    new Employee { employee_name = "Marlenka", position_id = positions[0].position_Id },
                    new Employee{ employee_name = "Julian", position_id = positions[1].position_Id },
                    new Employee{ employee_name = "Skiper",position_id = positions[1].position_Id}
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
