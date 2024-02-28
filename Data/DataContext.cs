using Microsoft.EntityFrameworkCore;
using ficaqui_api.Models;

namespace ficaqui_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Search> Searches { get; set; }
    }
}