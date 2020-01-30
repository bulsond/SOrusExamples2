using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Data;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        //данные программы
        private readonly IDataContext _data;
        //источник данных для ListBox & TextBoxes
        private readonly BindingSource _bsPeople;

        public FormMain()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пример работы с БД Access";

            //данные приложения
            //_data = new TestDataContext(); //работа без БД
            _data = new AccessDataContext(); //работа с БД Access
            _bsPeople = new BindingSource();
            
            //события
            this.Load += FormMain_Load;
            _buttonAdd.Click += ButtonAdd_Click;
            _buttonRemove.Click += ButtonRemove_Click;
            _buttonUpdate.Click += ButtonUpdate_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _bsPeople.DataSource = typeof(List<PersonViewModel>);
            //привязка ListBox
            _listBoxPeople.DataSource = _bsPeople;
            _listBoxPeople.DisplayMember = nameof(PersonViewModel.Fio);
            //привязки TextBoxов
            _textBoxFirstName.DataBindings.Add("Text", _bsPeople, nameof(PersonViewModel.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _bsPeople, nameof(PersonViewModel.LastName));
            _textBoxMiddleName.DataBindings.Add("Text", _bsPeople, nameof(PersonViewModel.MiddleName));

            //загрузка данных
            LoadPeople();
        }

        /// <summary>
        /// Загрузка списка людей
        /// </summary>
        private async void LoadPeople()
        {
            //получаем данные из БД
            List<PersonViewModel> people = await _data.LoadPeopleAsync();
            //отображаем данные
            _bsPeople.Clear();
            people.ForEach(p => _bsPeople.Add(p));
        }

        /// <summary>
        /// Кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            //новый для редактирования
            var person = new PersonViewModel();

            //готовим форму
            var formInput = new FormInput(person);
            formInput.Owner = this;
            formInput.StartPosition = FormStartPosition.CenterParent;
            formInput.Text = "Новый пользователь";

            //отображаем форму и получаем результат
            if (formInput.ShowDialog() != DialogResult.OK)
                return;

            //сохраняем в БД
            int result = await _data.AddPersonAsync(person);
            if (result > 0)
            {
                //отображаем нового
                _bsPeople.Add(person);
            }
            else
            {
                var message = $"Не удалось сохранить в базу данных {person.Fio}";
                var caption = "Ошибка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка Изменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //находим выделенного
            var person = _bsPeople.Current as PersonViewModel;
            if (person == null)
                return;

            //готовим форму
            var formInput = new FormInput(person);
            formInput.Owner = this;
            formInput.StartPosition = FormStartPosition.CenterParent;
            formInput.Text = $"Редактирование {person.Fio}";

            //отображаем форму и получаем результат
            if (formInput.ShowDialog() != DialogResult.OK)
                return;

            //сохраняем в БД
            int result = await _data.UpdatePersonAsync(person);
            if (result > 0)
            {
                //перезагружаем список людей из БД
                LoadPeople();
            }
            else
            {
                var message = $"Не удалось сохранить в базу данных {person.Fio}";
                var caption = "Ошибка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonRemove_Click(object sender, EventArgs e)
        {
            //находим выделенного
            var person = _bsPeople.Current as PersonViewModel;
            if (person == null)
                return;

            //спросим прежде чем удалять
            var message = $"Вы согласны удалить {person.Fio}?";
            var caption = "Запрос на удаление пользователя";
            if (MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //удаляем из БД
            int result = await _data.RemovePersonAsync(person);
            if (result > 0)
            {
                //перезагружаем список людей из БД
                LoadPeople();
            }
            else
            {
                message = $"Не удалось удалить из базы данных {person.Fio}";
                caption = "Ошибка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
