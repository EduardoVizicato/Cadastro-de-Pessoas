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
        public IActionResult Edit
            ()
        {
            return View();
        }
        public IActionResult DeleteConfirmation()
        {
            return View();
        }

       [HttpPost]
       public IActionResult Create(ContatoModelcs contato)
       {
           _contatoRepository.Adicionar (contato);
           return RedirectToAction("Index");
       }
    }
}
