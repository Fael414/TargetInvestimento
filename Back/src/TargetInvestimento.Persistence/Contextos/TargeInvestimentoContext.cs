using Microsoft.EntityFrameworkCore;
using TargetInvestimento.Domain;
namespace TargetInvestimento.Persistence
{
    public class TargeInvestimentoContext : DbContext
    {

        public TargeInvestimentoContext(DbContextOptions<TargeInvestimentoContext> options) : base(options) { }

        public DbSet<Cadastro_pessoa> Cadastro_Pessoas { get; set; }

        public DbSet<Perfil_usuario> Perfil_Usuarios { get; set; }
    }

}