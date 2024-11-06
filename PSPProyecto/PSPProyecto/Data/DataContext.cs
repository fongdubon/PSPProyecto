using PSPProyecto.Data.Entities;
using System.Data.Entity;

namespace PSPProyecto.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { set; get; }
        public DataContext() : base("name=con")
        {

        }
    }
}
