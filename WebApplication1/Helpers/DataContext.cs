using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpartaOficinas.Entities;

namespace SpartaOficinas.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration _config;

        public DataContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            var connectionString = _config.GetConnectionString("MySqlDatabase");
            opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Oficina> Oficinas { get; set; }
    }

}