using Microsoft.EntityFrameworkCore;
using BorsaHisseWeb.Models;

namespace BorsaHisseWeb.Data
{
    public class BorsaContext : DbContext
    {
        public BorsaContext(DbContextOptions<BorsaContext> options) : base(options) { }

        public DbSet<Hisse> Hisseler => Set<Hisse>();
    }
}
