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

namespace WindowsFormsApp
{
    public partial class FormInput : Form
    {
        //редактируемая модель
        public Person Person { get; private set; }

        public FormInput()
        {
            InitializeComponent();

            _buttonSave.Click += ButtonSave_Click;
            this.Load += FormInput_Load;
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            Person = new Person();
            //привязки свойств модели к текстбоксам
            _textBoxFirstName.DataBindings.Add("Text", Person, nameof(Person.FirstName));
            _textBoxLastName.DataBindings.Add("Text", Person, nameof(Person.LastName));
            //привязка ErrorProvider для отображения ошибок ввода
            _errorProvider.DataSource = Person;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
