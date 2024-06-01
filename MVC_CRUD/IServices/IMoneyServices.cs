using MVC_CRUD.Models;

namespace MVC_CRUD.IServices
{
    public interface IMoneyServices
    {
        List<Money> GetAll();
        Money GetById(string id);
        bool CreateMoney(Money money);
        bool UpdateMoney(Money money);
        bool DeleteMoney(string id);
    }
}
