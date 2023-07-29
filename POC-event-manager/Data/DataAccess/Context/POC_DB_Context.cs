using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using POC_event_manager.Data.DataAccess.Model;

namespace POC_event_manager.Data.DataAccess.Context
{
    public class POC_DB_Context : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string is the information to acces the database
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //defines a many to many relation between Events and Participants
            //modelBuilder.Entity<Event>()
                //.HasMany(e => e.Participants)
                //.WithMany(p => p.Events)
                //.UsingEntity(j => j.ToTable("EventParticipants"));
        }
    }
}
