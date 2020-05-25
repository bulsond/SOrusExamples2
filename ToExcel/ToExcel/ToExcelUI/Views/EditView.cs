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
    public interface IEditView
    {
        //редактируемый
        Person CurrentPerson { get; set; }

        //кнопка ОК
        SimpleButtonEventHandler OkPerson { get; set; }

        SimpleEventHandler PropertyChanged { set; }
    }

    public partial class EditView : Form, IEditView
    {
        private BindingSource _bsPerson = new BindingSource();
        private BindingSource _bsOk = new BindingSource();

        public EditView()
        {
            InitializeComponent();

            SetBindings();
        }

        private void SetBindings()
        {
            //редактируемый студент
            _bsPerson.DataSource = typeof(Person);
            _textBoxFirstName.DataBindings.Add("Text", _bsPerson, nameof(Person.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _bsPerson, nameof(Person.LastName));
            _textBoxAddress.DataBindings.Add("Text", _bsPerson, nameof(Person.Address));
            _textBoxPhone.DataBindings.Add("Text", _bsPerson, nameof(Person.Phone));

            //Кнопка ОК
            _bsOk.DataSource = typeof(SimpleButtonEventHandler);
            _buttonOK.DataBindings.Add("Enabled", _bsOk, "Enabled");
        }

        /// <summary>
        /// Редактируемый студент
        /// </summary>
        public Person CurrentPerson
        {
            get => _bsPerson.Current as Person;
            set
            {
                _bsPerson.Clear();
                _bsPerson.Add(value);
                _bsPerson.ResetBindings(false);
            }
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        public SimpleButtonEventHandler OkPerson
        {
            get => _bsOk.Current as SimpleButtonEventHandler;
            set
            {
                if (_bsOk.Count > 0) return;

                _bsOk.Clear();
                _bsOk.Add(value);
                _buttonOK.Click += value.Handler;
            }
        }

        /// <summary>
        /// Событие изменения текста в текстбоксах
        /// </summary>
        private SimpleEventHandler _PropertyChanged;
        public SimpleEventHandler PropertyChanged
        {
            get => _PropertyChanged;
            set
            {
                if (_PropertyChanged != null) return;

                _PropertyChanged = value;
                _bsPerson.CurrentItemChanged += value.Handler;

                //_textBoxFirstName.TextChanged += value.Handler;
                //_textBoxLastName.TextChanged += value.Handler;
                //_textBoxAddress.TextChanged += value.Handler;
                //_textBoxPhone.TextChanged += value.Handler;
            }
        }

    }
}
