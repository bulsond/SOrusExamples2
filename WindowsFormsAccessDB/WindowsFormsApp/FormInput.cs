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
        private readonly PersonViewModel _person;

        public FormInput(PersonViewModel person)
        {
            InitializeComponent();

            //
            _person = person;

            //настройка кнопок
            _buttonCancel.DialogResult = DialogResult.Cancel;
            _buttonOk.DialogResult = DialogResult.OK;
            this.CancelButton = _buttonCancel;
            this.AcceptButton = _buttonOk;

            this.Load += FormInput_Load;
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            //
            _textBoxFirstName.DataBindings.Add("Text", _person, nameof(PersonViewModel.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _person, nameof(PersonViewModel.LastName));
            _textBoxMiddleName.DataBindings.Add("Text", _person, nameof(PersonViewModel.MiddleName));
            _textBoxLogin.DataBindings.Add("Text", _person, nameof(PersonViewModel.Login));
            _textBoxPassword.DataBindings.Add("Text", _person, nameof(PersonViewModel.Password));
            _textBoxPassword2.DataBindings.Add("Text", _person, nameof(PersonViewModel.Password2));
        }
    }
}
