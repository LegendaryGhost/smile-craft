using Microsoft.EntityFrameworkCore;

namespace smile_craft.Data
{
    public partial class SmilecraftContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING");
            optionsBuilder.UseNpgsql(connectionString);
        }

    }
}
