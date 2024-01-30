using Microsoft.EntityFrameworkCore;
using smile_craft.Models;

namespace smile_craft.Data
{
    public partial class SmilecraftContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING");
            optionsBuilder.UseNpgsql(connectionString);
        }

        // Need to download EntityFramework.Relational to use shadow properties
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perform>()
                .Property<string>("OperationName")
                .Property<string>("CategoryName")
                .Property<int?>("CurrentMark")
                .Property<int?>("Price")
                .Property<string>("PriceString");
        }*/
    }
}
