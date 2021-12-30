namespace FirmaMF.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    class WarehouseStorageContextFactory : IDesignTimeDbContextFactory<WarehouseStorageContext>
    {
        public WarehouseStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=WarehouseStorage;Integrated Security=True");
            return new WarehouseStorageContext(optionsBuilder.Options);
        }
    }
}
