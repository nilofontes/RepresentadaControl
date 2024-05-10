using Microsoft.AspNetCore.Mvc;
using RepresentadaControl.Data;
using RepresentadaControl.Interfaces;

namespace RepresentadaControl.MVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultaClientes()
        {
            BaseCrud baseCrud = new BaseCrud();
            List<Cliente> clientes = baseCrud.GetAll();
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
