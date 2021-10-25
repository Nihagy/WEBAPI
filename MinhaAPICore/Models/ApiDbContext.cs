using Microsoft.EntityFrameworkCore;

namespace MinhaAPICore.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Agenda> Agendas { get; set; }
    }
}
