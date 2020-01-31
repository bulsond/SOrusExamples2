using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormChild : Form
    {
        private readonly TaskScheduler _uiScheduler;
        private readonly HttpClient _httpClient;

        public FormChild()
        {
            InitializeComponent();

            //запоминаем синхр.контекст
            _uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            //настройка клиента
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            //настройка таймера
            _timer.Interval = 2000;
            _timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Запуск Таймера
        /// </summary>
        public void Run()
        {
            _timer.Start();
        }

        /// <summary>
        /// Тик таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            //запускаем запрос к сайту и отображение результатов
            Task.Run(async () => await GetAnswer()).ContinueWith(t =>
            {
                _richTextBox.Text += t.Result;
            }, _uiScheduler);
        }

        /// <summary>
        /// Запрос к сайту API
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetAnswer()
        {
            string result = String.Empty;

            var response = await _httpClient.GetAsync("posts/1");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = BuildOutput(json);
            }
            else
            {
                result = response.StatusCode.ToString();
            }
            return result;
        }

        /// <summary>
        /// Парсинг ответа
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private string BuildOutput(string json)
        {
            dynamic blogPost = JObject.Parse(json);

            var builder = new StringBuilder();
            builder.AppendLine(new string('>', 45));
            builder.AppendLine($"[{ DateTime.Now.ToLocalTime()}]");
            builder.AppendLine($"Пользователь: {blogPost.userId}");
            builder.AppendLine($"Заголовок:{blogPost.title}");
            builder.AppendLine(new string('<', 45));
            builder.AppendLine();

            return builder.ToString();
        }
    }
}
