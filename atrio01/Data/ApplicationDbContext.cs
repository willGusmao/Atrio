using atrio01.Models;
using Microsoft.EntityFrameworkCore;

namespace atrio01.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
        }

        public DbSet<PacientesModel> Pacientes { get; set; }
        

    }
}
