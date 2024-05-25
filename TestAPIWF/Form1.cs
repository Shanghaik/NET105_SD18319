namespace TestAPIWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            double weight = Convert.ToDouble(tbt_weight.Text);
            double height = Convert.ToDouble(tbt_height.Text);
            // Các bước để call API
            // Bước 1: Lấy được đường dẫn requestURL (Bao gồm cả các parametor & giá trị nếu có)
            string requestURL = $@"https://localhost:7162/get-bmi?height={height}&weight={weight}";
            // Bước 2: Sử dụng HttpClient để lấy được responseBody
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(requestURL).Result;
            // Bước 3: Ép kiểu hoặc lấy ra dữ liệu nếu cần (Kết quả thu được ở dạng string)
            // Bước 4: Sử dụng dữ liệu mình vừa lấy được 
            lb_result.Text = "Kết quả "+ response;
            // Vì bài này chỉ cần string thôi nên bỏ qua bước 3
        }
    }
}