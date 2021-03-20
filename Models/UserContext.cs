using Microsoft.EntityFrameworkCore;

namespace calculadora_api.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> UserItems { get; set; }
        public DbSet<ChequeEmpresarial> ChequeEmpresarialItems { get; set; }
        public DbSet<ParceladoPre> ParceladoPreItems { get; set; }
        public DbSet<Indice> IndiceItems { get; set; }
        public DbSet<Log> LogItems { get; set; }
    }
}