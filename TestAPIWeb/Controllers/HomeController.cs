using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestAPIWeb.Models;

namespace TestAPIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult BMI(double height = 0, double weight = 0)
        {
            if (height == 0 && weight == 0) { // lần đầu chưa nhập gì hoặc nhập bằng 0 sẽ báo thế
                ViewData["result"] = "Bạn chưa nhập gì cả";
            }
            else
            {
                // Các bước để call API
                // Bước 1: Lấy được đường dẫn requestURL (Bao gồm cả các parametor & giá trị nếu có)
                string requestURL = $@"https://localhost:7162/get-bmi?height={height}&weight={weight}";
                // Bước 2: Sử dụng HttpClient để lấy được responseBody
                HttpClient client = new HttpClient();
                string response = client.GetStringAsync(requestURL).Result;
                // Bước 3: Ép kiểu hoặc lấy ra dữ liệu nếu cần (Kết quả thu được ở dạng string)
                // Bước 4: Sử dụng dữ liệu mình vừa lấy được 
                ViewData["result"] = response;
                // Vì bài này chỉ cần string thôi nên bỏ qua bước 3
            }
            return View();
        }
    }
}