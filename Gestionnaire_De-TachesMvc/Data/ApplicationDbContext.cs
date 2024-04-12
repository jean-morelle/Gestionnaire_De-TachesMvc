using Gestionnaire_De_TachesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestionnaire_De_TachesMvc.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet <Taches> taches { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base (options)
        {
            
        }
    }
}
