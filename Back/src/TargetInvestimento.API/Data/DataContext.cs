using Microsoft.EntityFrameworkCore;
namespace TargetInvestimento.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cadastro_pessoa> Cadastro_Pessoas { get; set; }
    }
}