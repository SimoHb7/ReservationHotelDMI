using Microsoft.EntityFrameworkCore;

namespace MvcHotelReservation.Data
{
    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options) : base(options)
        {

        }

        public DbSet<Models.User> User { get; set; }
        public DbSet<Models.WebClients> WebClients { get; set; }
    }
}
