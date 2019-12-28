using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsListViewPrint
{
    public partial class FormMain : Form
    {
        //список людей для печати
        private List<string> _peopleForPrint;

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Пример";
            this.StartPosition = FormStartPosition.CenterScreen;

            SetupListView();

            _buttonAdd.Click += ButtonAdd_Click;
            _buttonPrint.Click += ButtonPrint_Click;
            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        /// <summary>
        /// Настройка ListView
        /// </summary>
        private void SetupListView()
        {
            _listView.View = View.Details;
            _listView.FullRowSelect = true;
            _listView.GridLines = true;

            // Столбцы
            _listView.Columns.Add("Фамилия", 200, HorizontalAlignment.Center);
            _listView.Columns.Add("Имя", 150, HorizontalAlignment.Center);
            _listView.Columns.Add("Отчество", 250, HorizontalAlignment.Center);
        }

        /// <summary>
        /// Кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_textBoxFirstName.Text)
                || string.IsNullOrEmpty(_textBoxLastName.Text)
                || string.IsNullOrEmpty(_textBoxMiddleName.Text))
                return;

            ListViewItem item = new ListViewItem(_textBoxLastName.Text);
            item.SubItems.Add(_textBoxFirstName.Text);
            item.SubItems.Add(_textBoxMiddleName.Text);
            _listView.Items.Add(item);

            _textBoxFirstName.Clear();
            _textBoxLastName.Clear();
            _textBoxMiddleName.Clear();
            _textBoxLastName.Focus();
        }

        /// <summary>
        /// Кнопка Печать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            //список для печати
            _peopleForPrint = GetPeople();

            if (_printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                //размер бумаги
                PrinterSettings settings = new PrinterSettings();
                _printDocument.PrinterSettings = settings;
                var a4 = settings.PaperSizes
                                            .Cast<PaperSize>()
                                            .First(size => size.Kind == PaperKind.A4);
                _printDocument.DefaultPageSettings.PaperSize = a4;
                //печатаем
                _printDocument.Print();
            }

        }

        /// <summary>
        /// Извлечение списка людей из ListView
        /// </summary>
        /// <returns></returns>
        private List<string> GetPeople()
        {
            List<string> result = new List<string>();
            foreach (ListViewItem item in _listView.Items)
            {
                var lastName = item.SubItems[0].Text;
                var firstName = item.SubItems[1].Text;
                var middleName = item.SubItems[2].Text;
                result.Add($"{lastName} {firstName} {middleName}");
            }

            return result;
        }

        /// <summary>
        /// Печать страницы документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Список сотрудников",
                                new Font("Times New Romans", 16, FontStyle.Bold),
                                Brushes.Black,
                                new PointF(220, 100));

            if (_peopleForPrint == null || _peopleForPrint.Count == 0)
                return;

            float y = 150;
            foreach (var person in _peopleForPrint)
            {
                e.Graphics.DrawString(person,
                                new Font("Times New Romans", 14, FontStyle.Regular),
                                Brushes.Black,
                                new PointF(100, y += 30));
            }
        }
    }
}
