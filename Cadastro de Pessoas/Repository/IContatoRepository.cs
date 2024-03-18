using Cadastro_de_Pessoas.Models;

namespace Cadastro_de_Pessoas.Repository
{
    public interface IContatoRepository
    {
        ContatoModelcs ListId (int id);
        List<ContatoModelcs> buscarTodos();
        ContatoModelcs Adicionar(ContatoModelcs contato);

        ContatoModelcs edit (ContatoModelcs contato);

        bool delete (int id);
    }
}
