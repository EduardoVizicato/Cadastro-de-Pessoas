using Cadastro_de_Pessoas.Models;

namespace Cadastro_de_Pessoas.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModelcs> buscarTodos();
        ContatoModelcs Adicionar(ContatoModelcs contato);
    }
}
