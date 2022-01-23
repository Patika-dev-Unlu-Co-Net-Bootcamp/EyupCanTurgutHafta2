using Microsoft.AspNetCore.Mvc;
using System;

namespace UnluCoBootCamp.Odev1.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository=null;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            /*IRepository repository = new MySqlRepository();
            repository.Add();*/

            _repository.Add();
            return View();
        }
    }
}
