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
        //редактируемый чел
        private readonly PersonViewModel _person;
        //флаг возможно закрыть это окно
        private bool _closingShouldStopped;

        public FormInput(PersonViewModel person)
        {
            InitializeComponent();

            //текущий редактируемый
            _person = person;

            //настройка кнопок
            _buttonCancel.DialogResult = DialogResult.Cancel;
            _buttonOk.DialogResult = DialogResult.OK;
            this.CancelButton = _buttonCancel;
            this.AcceptButton = _buttonOk;

            this.Load += FormInput_Load;
            _buttonOk.Click += ButtonOk_Click;
            _buttonCancel.Click += ButtonCancel_Click;
        }

        

        private void FormInput_Load(object sender, EventArgs e)
        {
            //привязки к текстбоксам
            _textBoxFirstName.DataBindings.Add("Text", _person, nameof(PersonViewModel.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _person, nameof(PersonViewModel.LastName));
            _textBoxMiddleName.DataBindings.Add("Text", _person, nameof(PersonViewModel.MiddleName));
            _textBoxLogin.DataBindings.Add("Text", _person, nameof(PersonViewModel.Login));
            _textBoxPassword.DataBindings.Add("Text", _person, nameof(PersonViewModel.Password));
            _textBoxPassword2.DataBindings.Add("Text", _person, nameof(PersonViewModel.Password2));
            //привязываем отображение ошибок ввода
            _errorProvider.DataSource = _person;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            //проверяем введенные данные на валидность
            if (!String.IsNullOrEmpty(_person.Error))
            {
                //если не все данные введены правильно
                //запрещаем закрывать окно
                _closingShouldStopped = true;
                //
                var message = $"Не все данные введены верно!\n{_person.Error}";
                var caption = "Предупреждение";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //иначе разрешаем закрыть это окно
                _closingShouldStopped = false;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //разрешаем закрыть это окно
            _closingShouldStopped = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //запрещаем/разрешаем закрываться
            e.Cancel = _closingShouldStopped;
            base.OnClosing(e);
        }
    }
}
