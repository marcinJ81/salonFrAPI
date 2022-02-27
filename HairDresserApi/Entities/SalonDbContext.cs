using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{

    public class SalonDbContext : DbContext
    {
        public SalonDbContext(DbContextOptions<SalonDbContext> options)
             : base(options)
        {

        }
        private string connectionString = 
         "Data Source=komputerLeon;Initial Catalog=salonDB;User Id=sa; Password=Test1234!;Persist Security Info=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ServiceTable> ServiceTables { get; set; }
        public DbSet<StatusTable> StatusTables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Client>()
                .Property(x => x.client_name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Client>()
                .Property(x => x.client_phone)
                .IsRequired()
                .HasMaxLength(12);
           
            modelBuilder.Entity<Client>()
                .HasKey(x => x.client_id);

            modelBuilder.Entity<Employee>()
                .HasKey(x => x.employee_id);

            modelBuilder.Entity<Reservation>()
                .Property(x => x.reservation_date)
                .IsRequired();

            modelBuilder.Entity<ServiceTable>()
                .Property(x => x.service_price)
                .HasPrecision(4, 2);

            modelBuilder.Entity<StatusTable>()
                .HasData(new StatusTable { status_id = 1, status_name = "Rezerwacja" },
                         new StatusTable { status_id = 2, status_name = "W trakcie" },
                         new StatusTable { status_id = 3, status_name = "Zakończone" },
                         new StatusTable { status_id = 4, status_name = "Anulowane" }
                        );
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            
        }
    }
}
