using MVC_CRUD.IServices;
using MVC_CRUD.Models;
using Newtonsoft.Json;

namespace MVC_CRUD.Services
{
    public class MoneyServices : IMoneyServices
    {
        HttpClient _client;
        public MoneyServices()
        {
            _client = new HttpClient();
        }
        public bool CreateMoney(Money money)
        {
            // lấy requestURL
            string requestURL = "https://localhost:7152/api/Money/create-money";
            // tạo response
            var response = _client.PostAsJsonAsync(requestURL, money).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool DeleteMoney(string id)
        {
            string requestURL = $"https://localhost:7152/api/Money/delete-money?id={id}";
            var response = _client.DeleteAsync(requestURL).Result;
            if(response.IsSuccessStatusCode) return true;
            return false;
        }

        public List<Money> GetAll()
        {
            string requestURL = "https://localhost:7152/api/Money/get-all-money";
            var response = _client.GetStringAsync(requestURL).Result; 
            List<Money> result = JsonConvert.DeserializeObject<List<Money>>(response);
            return result;
        }

        public Money GetById(string id)
        {
            string requestURL = $"https://localhost:7152/api/Money/get-by-id?id={id}";
            var response = _client.GetStringAsync(requestURL).Result;
            Money result = JsonConvert.DeserializeObject<Money>(response);
            return result;
        }

        public bool UpdateMoney(Money money)
        {
            string requestURL = "https://localhost:7152/api/Money/update-money";
            // tạo response
            var response = _client.PutAsJsonAsync(requestURL, money).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
// 1. Khi chúng ta viết API là phương thức nào thì khi call cũng phải là phương thức đó
// 2. Razor view (cái mà mình gen ra view ấy) chỉ support HTTPPOST và HTTPGET thôi nên bên MVC
// chúng ta chỉ viết GET và Post mà không cần quan tâm đến bên Services nó dùng gì