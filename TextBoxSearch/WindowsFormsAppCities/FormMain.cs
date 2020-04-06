using System;
using System.Windows.Forms;
using WindowsFormsAppCities.Models;
using WindowsFormsAppCities.Services;

namespace WindowsFormsAppCities
{
    public partial class FormMain : Form
    {
        private readonly CitiesService _citiesService;

        public FormMain()
        {
            InitializeComponent();

            _citiesService = new CitiesService();
            this.Load += FormMain_Load;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await _citiesService.InitAsync();

            _textBoxInput.TextChanged += OnTextBoxInput_TextChanged;
            _comboBoxInput.KeyUp += OnComboBoxInput_KeyUp;
            _comboBoxInput.TextChanged += OnComboBoxInput_TextChanged;
            _comboBoxInput.SelectionChangeCommitted += _comboBoxInput_SelectionChangeCommitted;
        }

        private void _comboBoxInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _textBoxInput.Text = _comboBoxInput.Text;
        }

        private void OnComboBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                int sStart = _comboBoxInput.SelectionStart;
                if (sStart > 0)
                {
                    sStart--;
                    if (sStart == 0)
                    {
                        _comboBoxInput.Text = "";
                    }
                    else
                    {
                        _comboBoxInput.Text = _comboBoxInput.Text.Substring(0, sStart);
                    }
                }
                e.Handled = true;
            }
        }

        private void OnComboBoxInput_TextChanged(object sender, EventArgs e)
        {
            var input = _comboBoxInput.Text.Trim();
            var cities = _citiesService.GetCitiesStartsWith(input);

            if (cities.Count > 0)
            {
                _comboBoxInput.DataSource = cities;
                _comboBoxInput.DisplayMember = nameof(City.Name);
                var sText = _comboBoxInput.Items[0].ToString();
                _comboBoxInput.SelectionStart = input.Length;
                _comboBoxInput.SelectionLength = sText.Length - input.Length;
                _comboBoxInput.DroppedDown = true;
            }
            else
            {
                _comboBoxInput.DroppedDown = false;
                _comboBoxInput.SelectionStart = input.Length;
            }
        }

        private void OnTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            var input = _textBoxInput.Text.Trim();
            if (String.IsNullOrEmpty(input))
                return;
            var cities = _citiesService.GetCitiesStartsWith(input);
            _comboBoxInput.DataSource = cities;
            _comboBoxInput.DisplayMember = nameof(City.Name);
        }
    }
}
