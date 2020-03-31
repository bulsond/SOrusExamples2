using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.Data;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        //источник данных для DGV
        private BindingSource _bsModels;
        //данные
        private AppData _appData;

        public FormMain()
        {
            InitializeComponent();

            _appData = new AppData();
            _bsModels = new BindingSource();

            //привязки DGV & столбцов
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.DataSource = _bsModels;
            _columnTitle.DataPropertyName = nameof(Model.Title);
            _columnYear.DataPropertyName = nameof(Model.Year);
            _columnType.DataPropertyName = nameof(Model.Type);
            _columnPrice.DataPropertyName = nameof(Model.Price);

            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //заполняем DGV
            _appData.GetModels()
                    .ToList()
                    .ForEach(m => _bsModels.Add(m));

            //заполняем комбобокс
            var types = new List<string> { "Все" };
            types.AddRange(_appData.GetModelsTypes());
            _comboBoxType.DataSource = types;

            //подписка на выбор в комбобксе
            _comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            //подписка на 2-й клик в DGV
            _dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //очищаем DGV
            _bsModels.Clear();

            var type = (sender as ComboBox).Text;
            if (type != "Все")
            {
                //заполняем нужным типом
                _appData.GetModelsByType(type)
                        .ToList()
                        .ForEach(m => _bsModels.Add(m));
            }
            else
            {
                //извлекаем, заполняем полным списком
                _appData.GetModels()
                        .ToList()
                        .ForEach(m => _bsModels.Add(m));
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //определяем выбранную в DGV модель
            var model = _bsModels.Current as Model;

            //создаем экз.формы с передачей выбранной модели
            var formCars = new FormCars(model);
            formCars.Owner = this;
            formCars.ShowDialog();
        }
    }
}
