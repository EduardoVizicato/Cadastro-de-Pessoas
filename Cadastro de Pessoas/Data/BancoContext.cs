using Cadastro_de_Pessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_de_Pessoas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModelcs> Contatos { get; set; }
    }
}
