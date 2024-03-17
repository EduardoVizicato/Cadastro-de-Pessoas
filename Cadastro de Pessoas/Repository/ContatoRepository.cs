using Cadastro_de_Pessoas.Data;
using Cadastro_de_Pessoas.Models;

namespace Cadastro_de_Pessoas.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public ContatoModelcs Adicionar(ContatoModelcs contato)
        {
            //gravar banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}
