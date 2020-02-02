using System;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class FormInput : Form
    {
        //редактируемая модель
        private readonly Person _person;

        //событие готовности данных для чтения FormMain
        public EventHandler DataEntered;

        public FormInput()
        {
            InitializeComponent();

            _person = new Person();

            _buttonSave.Click += ButtonSave_Click;
            this.Load += FormInput_Load;
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            //привязки свойств модели к текстбоксам
            _textBoxFirstName.DataBindings.Add("Text", _person, nameof(_person.FirstName),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxLastName.DataBindings.Add("Text", _person, nameof(_person.LastName),
                true, DataSourceUpdateMode.OnPropertyChanged);
            //привязка ErrorProvider для отображения ошибок ввода
            _errorProvider.DataSource = _person;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            //проверяем введенные данные на валидность
            if (_person.IsValid())
            {
                var message = $"Не все данные введены верно!\n{_person.Error}";
                var caption = "Предупреждение";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //данные валидные значит вызываем событие для оповещения FormMain
            DataEntered?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Получение чела для вставки в DGV
        /// </summary>
        /// <param name="number">назначаемый порядковый номер</param>
        /// <returns>экземпляр Person</returns>
        public Person GetPerson(int number)
        {
            //создаем нового чела для передачи
            var result = new Person
            {
                OrderNumber = number,
                FirstName = new string(_person.FirstName.Trim().ToCharArray()),
                LastName = new string(_person.LastName.Trim().ToCharArray()),
            };

            //поля ввода очищаем
            _textBoxFirstName.Text = String.Empty;
            _textBoxLastName.Text = String.Empty;
            _textBoxFirstName.Focus();

            return result;
        }
    }
}
