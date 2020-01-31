using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            _toolStripMenuItemNew.Click += MenuItemNew_Click;
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            var form = new FormChild();
            form.MdiParent = this;
            //запускаем таймер и запросы к API
            form.Run();
            //отображаем окно
            form.Show();
        }
    }
}
