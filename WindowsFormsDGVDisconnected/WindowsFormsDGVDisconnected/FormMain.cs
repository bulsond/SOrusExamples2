using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsDGVDisconnected
{
    public partial class FormMain : Form
    {
        private readonly DataContext _dataContext;
        public FormMain()
        {
            InitializeComponent();

            _dataContext = new DataContext();

            _dataGridView.AutoGenerateColumns = false;
            _columnCity.DataPropertyName = "City";
            _columnStreet.DataPropertyName = "Street";
            _columnBuilding.DataPropertyName = "Building";
            _columnApartment.DataPropertyName = "Apartment";

            this.Load += FormMain_Load;
            _buttonSave.Click += ButtonSave_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var dataTable = _dataContext.GetRealEstatesOrNull();
            if (dataTable != null)
            {
                _dataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Не удалось получить данные из БД", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var oldTable = (DataTable)_dataGridView.DataSource;
            var newTable = _dataContext.UpdateRealEstatesOrNull(oldTable);
            if (newTable != null)
            {
                _dataGridView.DataSource = newTable;
            }
            else
            {
                MessageBox.Show("Не удалось сохранить данные в БД", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
