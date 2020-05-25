using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToExcelUI.Models;
using ToExcelUI.Views.EventHandlers;

namespace ToExcelUI.Views
{
    public interface IMainView
    {
        List<Person> People { get; set; }
        Person SelectedPerson { get; }

        SimpleButtonEventHandler AddPerson { set; }
        SimpleButtonEventHandler UpdatePerson { set; }
        SimpleButtonEventHandler RemovePerson { set; }
    }

    public partial class MainView : Form, IMainView
    {
        private BindingSource _bsPeople = new BindingSource();

        public MainView()
        {
            InitializeComponent();

            SetBindings();
            
            this.CenterToScreen();
            this.Text = "Телефонная книга";
        }

        private void SetBindings()
        {
            //список
            _bsPeople.DataSource = typeof(List<Person>);
            _listBoxPeople.DisplayMember = nameof(Person.ForList);
            _listBoxPeople.DataSource = _bsPeople;

            //данные по выбранному
            _textBoxFirstName.DataBindings.Add("Text", _bsPeople, nameof(Person.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _bsPeople, nameof(Person.LastName));
            _textBoxAddress.DataBindings.Add("Text", _bsPeople, nameof(Person.Address));
            _textBoxPhone.DataBindings.Add("Text", _bsPeople, nameof(Person.Phone));
        }

        /// <summary>
        /// Список людей
        /// </summary>
        public List<Person> People
        {
            get => _bsPeople.List as List<Person>;
            set
            {
                _bsPeople.Clear();
                _bsPeople.DataSource = value;
                _bsPeople.ResetBindings(false);
            }
        }

        /// <summary>
        /// Выбранный в списке
        /// </summary>
        public Person SelectedPerson => _bsPeople.Current as Person;


        /// <summary>
        /// Кнопка Добавить
        /// </summary>
        private SimpleButtonEventHandler _AddPerson;
        public SimpleButtonEventHandler AddPerson
        {
            set
            {
                if (_AddPerson != null) return;

                _AddPerson = value;
                _buttonAdd.Click += value.Handler;
            }
        }

        /// <summary>
        /// Кнопка Редактировать
        /// </summary>
        private SimpleButtonEventHandler _UpdatePerson;
        public SimpleButtonEventHandler UpdatePerson
        {
            set
            {
                if (_UpdatePerson != null) return;

                _UpdatePerson = value;
                _buttonUpdate.Click += value.Handler;
            }
        }

        /// <summary>
        /// Кнопка Удалить
        /// </summary>
        private SimpleButtonEventHandler _RemovePerson;
        public SimpleButtonEventHandler RemovePerson
        {
            set
            {
                if (_RemovePerson != null) return;

                _RemovePerson = value;
                _buttonRemove.Click += value.Handler;
            }
        }

    }
}
