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

        public List<ContatoModelcs> buscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModelcs Adicionar(ContatoModelcs contato)
        {
            //gravar banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModelcs ListId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.id == id);
        }

        public ContatoModelcs edit(ContatoModelcs contato)
        {
            ContatoModelcs contatoDB = ListId(contato.id);

            if(contatoDB == null)
            {
                new System.Exception("houve um erro na atualização");
            }

            contatoDB.nome = contato.nome;
            contatoDB.email = contato.email;
            contatoDB.celular = contato.celular;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }

        public bool delete(int id)
        {
            ContatoModelcs contatoDB = ListId(id);

            if (contatoDB == null)
            {
                new System.Exception("houve um erro na deleção do contato !!");

            }

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
             return true;
        }
    }
}
