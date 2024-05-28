using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TestAPIWeb.Controllers
{
    public class TreeController : Controller
    {
        public IActionResult Index() // Lấy ra cái danh sách tree và hiển thị ra trên
        {
            // Bước 1: Lấy requestURL
            string requestURL = @"https://localhost:7162/api/Tree/get-fake-tree";
            // Bước 2: Lấy response
            HttpClient client= new HttpClient();
            var response = client.GetStringAsync(requestURL).Result;
            // Bước 3: ÉP kiểu nếu cần (DÙng thư viện Newtonsoft.Json để ép từ jsonString -> List
            List<Tree> trees = JsonConvert.DeserializeObject<List<Tree>>(response);
            // Bước 4: Sử dụng data
            return View(trees);
        }
    }
    public class Tree
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
