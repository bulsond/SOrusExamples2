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

namespace WinFormsUI
{
    public partial class FormMain : Form
    {
        private InputView _inputView;

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Пример";
            this.StartPosition = FormStartPosition.CenterScreen;

            SetBinding();
            _buttonStart.Click += ButtonStart_Click;
        }

        private void SetBinding()
        {
            _inputView = new InputView();
            _textBoxAddress.DataBindings.Add("Text", _inputView,
                nameof(InputView.Address), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxParam.DataBindings.Add("Text", _inputView,
                nameof(InputView.Parameter), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxFrom.DataBindings.Add("Text", _inputView,
                nameof(InputView.From), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxTo.DataBindings.Add("Text", _inputView,
                nameof(InputView.To), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var address = _inputView.Address;

            throw new NotImplementedException();
        }
    }
}
