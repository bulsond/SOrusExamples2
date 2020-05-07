using BelTamojService.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelTamojService
{
    public partial class FormMain : Form
    {
        private readonly DataService _dataService;
        private int _pageNumber = 1;
        private const string _counterInfo = "Страница {0}, всего позиций {1}";

        public FormMain()
        {
            InitializeComponent();

            _dataService = new DataService();
            this.Load += FormMain_Load;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
             await LoadPage();
            _buttonPage.Click += ButtonPage_Click;
        }

        private async void ButtonPage_Click(object sender, EventArgs e)
        {
            if (int.TryParse(_textBoxPageNumber.Text, out _pageNumber)
                && _pageNumber >= 1)
            {
                await LoadPage();
            }
            else
            {
                MessageBox.Show("Неверный номер страницы.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadPage()
        {
            var page = await _dataService.GetPageAsync(_pageNumber);
            if (!String.IsNullOrEmpty(page.StatusCode))
            {
                var message = $"Не удалось загрузить страницу\nсервер вернул {page.StatusCode}";
                MessageBox.Show(message, "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _dataGridView.DataSource = page.result;
            _labelCounter.Text = String.Format(_counterInfo, _pageNumber, page.result.Length);
            _textBoxPageNumber.Text = _pageNumber.ToString();
        }
    }
}
