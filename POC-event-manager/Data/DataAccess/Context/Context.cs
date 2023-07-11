using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using POC_event_manager.Data.DataAccess.Model;

namespace POC_event_manager.Data.DataAccess.Context
{
    public class Context : DbContext
    {
        public DbSet<Event> Blogs { get; set; }
        public DbSet<Participant> Posts { get; set; }
        public string DbPath { get; }
        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "POCDatabase.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }

}
