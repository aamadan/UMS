using Microsoft.EntityFrameworkCore;
using UMS.Models;
namespace UMS.Data
{
    public class MyAppContext:DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
        }

        public DbSet<UsersModel> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
