using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsListBox.Models;

namespace WindowsFormsListBox
{
    public partial class FormMain : Form
    {
        //источник данных для ListBox
        private BindingSource _bsProducts;

        public FormMain()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пример ввода данных и  их отображения";

            //установка привязок
            SetBindings();

            //
            _buttonAddProduct.Click += ButtonAddProduct_Click;
            _buttonRemoveProduct.Click += ButtonRemoveProduct_Click;
        }

        private void SetBindings()
        {
            _bsProducts = new BindingSource();
            _bsProducts.DataSource = typeof(List<Product>);
            //
            _listBoxProducts.DataSource = _bsProducts;
            _listBoxProducts.DisplayMember = nameof(Product.Name);
            //
            _textBoxName.DataBindings.Add("Text", _bsProducts, nameof(Product.Name));
            _textBoxCity.DataBindings.Add("Text", _bsProducts, nameof(Product.City));
            _textBoxPrice.DataBindings.Add("Text", _bsProducts, nameof(Product.Price));
        }

        /// <summary>
        /// Кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = "<?>",
                City = "<?>",
                Price = 0
            };

            var inputForm = new FormInputProduct(product);
            inputForm.Owner = this;
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.Text = "Новый товар";

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                _bsProducts.Add(product);
            }
        }

        /// <summary>
        /// Кнопка Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            _bsProducts.RemoveCurrent();
        }
    }
}
