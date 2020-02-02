using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        //ссылка на форму ввода данных
        private FormInput _inputForm;
        //источник данных для DGV
        private readonly BindingSource _bsPeople;

        public FormMain()
        {
            InitializeComponent();

            _bsPeople = new BindingSource();

            _buttonOpenInput.Click += ButtonOpenInput_Click;
            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _bsPeople.DataSource = typeof(List<Person>);
            //привязка к данным DGV
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.DataSource = _bsPeople;
            //привязка свойств модели к колонкам DGV
            _columnOrderNumber.DataPropertyName = nameof(Person.OrderNumber);
            _columnLastName.DataPropertyName = nameof(Person.LastName);
            _columnFirstName.DataPropertyName = nameof(Person.FirstName);
        }

        /// <summary>
        /// Кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenInput_Click(object sender, EventArgs e)
        {
            if (_inputForm != null)
                return;

            _inputForm = new FormInput();
            _inputForm.Owner = this;
            //подписываемся на событие готовности данных
            _inputForm.DataEntered += FormInput_DataEntered;
            _inputForm.FormClosed += InputForm_FormClosed;
            //отображаем форму
            _inputForm.Show();
        }

        /// <summary>
        /// Обработчик события готовности данных в FormInput
        /// Здесь мы извлекаем данные и вносим их в DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInput_DataEntered(object sender, EventArgs e)
        {
            //вычисляем порядковый номер для след.чела
            int number = _bsPeople.Count + 1;
            //добавляем в DGV нового чела
            _bsPeople.Add(_inputForm.GetPerson(number));
        }

        /// <summary>
        /// Обработчик события закрытия формы ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _inputForm = null;
        }
    }
}
