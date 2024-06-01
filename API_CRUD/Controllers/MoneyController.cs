using API_CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();
        [HttpGet("get-all-money")]
        public ActionResult GetAll() // Trả về danh sách tất cả các loại tiền
        {
            return Ok(_context.Moneys.ToList());
        }
        [HttpGet("get-by-id")]
        public ActionResult GetByID(string id) {
            return Ok(_context.Moneys.Find(id));
        }
        [HttpPost("create-money")]
        public ActionResult CreateMoney(Money money)
        {
            try
            {
                _context.Moneys.Add(money);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("update-money")]
        public ActionResult UpdateMoney(Money money)
        {
            try
            {
                var updateItem = _context.Moneys.Find(money.Id);
                updateItem.Name = money.Name;
                updateItem.Serial = money.Serial;
                _context.Moneys.Update(updateItem);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("delete-money")]
        public ActionResult DeleteMoney(string id) {
            try
            {
                var deleteItem = _context.Moneys.Find(id);
                _context.Moneys.Remove(deleteItem);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
