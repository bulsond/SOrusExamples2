using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Models;
using WinFormsUI.Services;

namespace WinFormsUI
{
    public partial class FormMain : Form
    {
        private InputView _inputView;
        private DownloadService _service;
        private BindingSource _bsItems;

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Пример";
            this.StartPosition = FormStartPosition.CenterScreen;

            _inputView = new InputView();
            _service = new DownloadService();
            SetBinding();
            _buttonStart.Click += ButtonStart_Click;
        }

        private void SetBinding()
        {
            _textBoxAddress.DataBindings.Add("Text", _inputView,
                nameof(InputView.Address), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxParam.DataBindings.Add("Text", _inputView,
                nameof(InputView.Parameter), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxFrom.DataBindings.Add("Text", _inputView,
                nameof(InputView.From), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxTo.DataBindings.Add("Text", _inputView,
                nameof(InputView.To), true, DataSourceUpdateMode.OnPropertyChanged);

            _bsItems = new BindingSource();
            _bsItems.DataSource = typeof(List<Item>);
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.DataSource = _bsItems;
            _columnNumber.DataPropertyName = nameof(Item.Number);
            _columnAddress.DataPropertyName = nameof(Item.Address);
            _columnResponse.DataPropertyName = nameof(Item.Response);
        }

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            var items = _inputView.GetItems();
            if (items.Count == 0)
            {
                var message = "Требуется правильное заполнение полей.";
                var caption = "Сообщение";
                MessageBox.Show(message, caption,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int number = 0;
            items.ForEach(i => i.Number = ++number);

            _progressBar.Maximum = items.Count;
            var progress = new Progress<int>(p =>
            {
                _progressBar.Value = p;
            });
            await _service.GetItemsResposesAsync(items, progress);

            _bsItems.Clear();
            items.ForEach(i => _bsItems.Add(i));
        }
    }
}
