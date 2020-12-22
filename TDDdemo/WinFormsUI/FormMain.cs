using Rectangle.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class FormMain : Form
    {
        private readonly MainFormViewModel _viewModel = new MainFormViewModel();

        public FormMain()
        {
            InitializeComponent();

            //привязки
            _textBoxWidth.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.Width));
            _textBoxLength.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.Length));

            _buttonDoCalc.Click += ButtonDoCalc_Click;
        }

        private void ButtonDoCalc_Click(object sender, EventArgs e)
        {
            try
            {
                _labelArea.Text = _viewModel.GetArea().ToString();
                _labelPerimeter.Text = _viewModel.GetPerimeter().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
