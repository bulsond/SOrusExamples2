using System;
using System.Windows.Forms;
using WindowsFormsListBox.Models;

namespace WindowsFormsListBox
{
    public partial class FormInputProduct : Form
    {
        //Редактируемый продукт
        public Product Product { get; }

        public FormInputProduct(Product product)
        {
            InitializeComponent();
            Product = product ?? throw new ArgumentNullException(nameof(product));

            //назначаем кнопкам результаты
            _buttonCancel.DialogResult = DialogResult.Cancel;
            _buttonOk.DialogResult = DialogResult.OK;
            this.CancelButton = _buttonCancel;
            this.AcceptButton = _buttonOk;

            this.Load += FormInputProduct_Load;
        }

        private void FormInputProduct_Load(object sender, EventArgs e)
        {
            //привязки
            _textBoxName.DataBindings.Add("Text", Product, nameof(Product.Name));
            _textBoxCity.DataBindings.Add("Text", Product, nameof(Product.City));
            _textBoxPrice.DataBindings.Add("Text", Product, nameof(Product.Price));
        }
    }
}
