using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        private FormInput _inputForm;

        public FormMain()
        {
            InitializeComponent();

            _buttonOpenInput.Click += ButtonOpenInput_Click;
        }

        private void ButtonOpenInput_Click(object sender, EventArgs e)
        {
            if (_inputForm != null)
                return;

            _inputForm = new FormInput();
            _inputForm.Owner = this;
            _inputForm.Show();
        }
    }
}
