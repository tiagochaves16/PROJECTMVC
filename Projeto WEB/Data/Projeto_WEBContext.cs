using Microsoft.EntityFrameworkCore;
using Projeto_WEB.Models;

namespace Projeto_WEB.Data
{
    public class Projeto_WEBContext : DbContext
    {
        public Projeto_WEBContext (DbContextOptions<Projeto_WEBContext> options)
            : base(options)
        {
        }



        public DbSet<Department> Department { get; set; }
        public DbSet <Seller> Seller { get; set; }
        public DbSet <SalesRecord> SalesRecords { get; set; }
        
    }

}
