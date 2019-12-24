using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Models;
using WinFormsUI.Services;

namespace WinFormsUI
{
    public partial class FormMain : Form
    {
        //вводимые данные
        private InputViewModel _inputViewModel;
        //сервис работы с сетью
        private DownloadService _service;
        //источник токена отмена загрузки
        private CancellationTokenSource _tcs;
        //источник данных для DGV
        private BindingSource _bsItems;

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Пример";
            this.StartPosition = FormStartPosition.CenterScreen;
            //иниц. сервиса
            _service = new DownloadService();
            //привязки
            SetBinding();
            //кнопки
            _buttonStart.Click += ButtonStart_Click;
            _buttonCancel.Click += ButtonCancel_Click;
        }

        /// <summary>
        /// Установка привязок
        /// </summary>
        private void SetBinding()
        {
            //текстбоксы
            _inputViewModel = new InputViewModel();
            _textBoxAddress.DataBindings.Add("Text", _inputViewModel,
                nameof(InputViewModel.Address), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxParam.DataBindings.Add("Text", _inputViewModel,
                nameof(InputViewModel.Parameter), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxFrom.DataBindings.Add("Text", _inputViewModel,
                nameof(InputViewModel.From), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxTo.DataBindings.Add("Text", _inputViewModel,
                nameof(InputViewModel.To), true, DataSourceUpdateMode.OnPropertyChanged);
            //DGV
            _bsItems = new BindingSource();
            _bsItems.DataSource = typeof(List<Item>);
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.DataSource = _bsItems;
            _columnNumber.DataPropertyName = nameof(Item.Number);
            _columnAddress.DataPropertyName = nameof(Item.Address);
            _columnResponse.DataPropertyName = nameof(Item.Response);
        }

        /// <summary>
        /// Кнопка Старт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            var items = _inputViewModel.GetItems();
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

            _buttonCancel.Enabled = true;
            _buttonStart.Enabled = false;

            _progressBar.Maximum = items.Count;
            var progress = new Progress<int>(p =>
            {
                _progressBar.Value = p;
            });
            _tcs = new CancellationTokenSource();
            var token = _tcs.Token;

            try
            {
                await _service.GetItemsResposesAsync(items, progress, token);
            }
            finally
            {
                _tcs.Dispose();
                _buttonCancel.Enabled = false;
                _buttonStart.Enabled = true;
                _progressBar.Value = 0;

                _bsItems.Clear();
                items.ForEach(i => _bsItems.Add(i));
            }
        }

        /// <summary>
        /// Кнопка Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _tcs.Cancel();
        }
    }
}
