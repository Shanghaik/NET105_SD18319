using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.IServices;
using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class MoneyController : Controller
    {
        IMoneyServices _services;
        public MoneyController(IMoneyServices services)
        {
            _services = services;
        }
        public IActionResult GetAll()
        {
            List<Money> moneys = _services.GetAll();
            return View(moneys);
        }
    }
}
