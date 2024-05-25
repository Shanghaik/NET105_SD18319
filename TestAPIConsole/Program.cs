namespace TestAPIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Nhập liệu đã
            Console.WriteLine("Please enter your weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height:");
            double height = Convert.ToDouble(Console.ReadLine());
            // Các bước để call API
            // Bước 1: Lấy được đường dẫn requestURL (Bao gồm cả các parametor & giá trị nếu có)
            string requestURL = $@"https://localhost:7162/get-bmi?height={height}&weight={weight}";
            // Bước 2: Sử dụng HttpClient để lấy được responseBody
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(requestURL).Result;
            // Bước 3: Ép kiểu hoặc lấy ra dữ liệu nếu cần (Kết quả thu được ở dạng string)
            // Bước 4: Sử dụng dữ liệu mình vừa lấy được 
            Console.WriteLine(response);
            // Vì bài này chỉ cần string thôi nên bỏ qua bước 3
        }
    }
}