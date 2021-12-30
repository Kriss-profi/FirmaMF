

namespace FirmaMF.DataAccess
{
    using FirmaMF.DataAccess.Entities;
    using Microsoft.EntityFrameworkCore;

    public class WarehouseStorageContext : DbContext
    {
        public WarehouseStorageContext(DbContextOptions<WarehouseStorageContext> opt) : base(opt)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Address> Adreses { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
