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
        }

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            var items = _inputView.GetItems();
            if (items.Count == 0)
            {
                return;
            }

            int number = 0;
            items.ForEach(i => i.Number = ++number);

            _progressBar.Maximum = items.Count;
            var progress = new Progress<int>((p) =>
            {
                _progressBar.Value = p;
            });
            await _service.GetItemsResposesAsync(items, progress);

        }
    }
}
