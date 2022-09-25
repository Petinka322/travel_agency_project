namespace Data
{
    using Microsoft.EntityFrameworkCore;
    using Model;

    public class DestinationContext:DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NFLODBL\SQLEXPRESS;Database=DestinationDb;Trusted_Connection=True; ");
        }
    }
}