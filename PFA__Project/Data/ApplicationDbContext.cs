using Microsoft.EntityFrameworkCore;

namespace PFA_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {          
        }



    }
}
