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
        // Class A kế thừa Class B thì A sẽ phụ thuộc vào B
        // Nếu Class A kế thừa Interface B thì nếu dùng instance cho B sẽ buộc
        // phải phụ thuộc vào A
        public IActionResult GetAll()
        {
            List<Money> moneys = _services.GetAll();
            return View(moneys);
        }
        public IActionResult Details(string id) { // xem details của tiền
            var data = _services.GetById(id);
            return View(data);
        }
        public IActionResult Create() {
            var data = new Money() // Tạo ra để fill vào form thôi
            {
                Name = "Tiền tệ",
                Country = "Chila",
                Serial = "00000",
                Value = 10000
            };
            return View(data);  
        }
        [HttpPost]
        public IActionResult Create(Money m)
        {
            _services.CreateMoney(m);
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(string id)
        {
            var data = _services.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Money m)
        {
            _services.UpdateMoney(m);
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(string id)
        {
            _services.DeleteMoney(id);
            return RedirectToAction("GetAll");
        }
    }
}
