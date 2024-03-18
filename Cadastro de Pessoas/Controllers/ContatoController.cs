using Cadastro_de_Pessoas.Models;
using Cadastro_de_Pessoas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_de_Pessoas.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository; 
        }
        public IActionResult Index()
        {
            List<ContatoModelcs> contatos = _contatoRepository.buscarTodos();


            return View(contatos);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            ContatoModelcs contato = _contatoRepository.ListId(id);
            return View(contato);
        }
        public IActionResult DeleteConfirmation(int id)
        {
            ContatoModelcs contato = _contatoRepository.ListId(id);
            return View(contato );
        }

       [HttpPost]
       public IActionResult Create(ContatoModelcs contato)
       {
           _contatoRepository.Adicionar (contato);
           return RedirectToAction("Index");
       }
        [HttpPost]
        public IActionResult Edit(ContatoModelcs contato)
        {
            _contatoRepository.edit(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _contatoRepository.delete(id);
            return RedirectToAction("Index");
        }
    }
}
