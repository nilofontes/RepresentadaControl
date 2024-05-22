using Microsoft.AspNetCore.Mvc;
using RepresentadaControl.Data;
using RepresentadaControl.Interfaces;

namespace RepresentadaControl.MVC.Controllers
{
    public class FornecedorController : Controller
    {
        public IActionResult Index()
        {
            BaseCrud<Fornecedor> baseCrud = new BaseCrud<Fornecedor>();
            List<Fornecedor> fornecedores = baseCrud.GetAll();
            return View((IEnumerable<Fornecedor>)fornecedores);
        }

        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Fornecedor cliente)
        {
            FornecedorCrud clienteCrud = new FornecedorCrud();
            clienteCrud.Create(cliente);
            ModelState.Clear();
            return View();
        }

        public IActionResult Edit(int id)
        {           

            BaseCrud<Fornecedor> baseCrud = new BaseCrud<Fornecedor>();
            Fornecedor cliente = baseCrud.GetById(id);
            return View(cliente);
        }

    }
}
