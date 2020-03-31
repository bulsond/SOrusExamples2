using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.ViewModel;

namespace WindowsFormsApp
{
    public partial class FormCars : Form
    {
        //модель авто которой показаны
        private Model _model;
        //источник данных для DGV
        private BindingSource _bsCars;
        //источник привязки для текстбоксов поиска по цене
        private CarsViewModel _viewModel;
        public FormCars(Model model)
        {
            if (model is null)
                throw new ArgumentNullException(nameof(model));

            InitializeComponent();

            _model = model;
            _bsCars = new BindingSource();
            //привязки DGV & столбцов
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.DataSource = _bsCars;
            _columnModel.DataPropertyName = nameof(Car.Model);
            _columnYear.DataPropertyName = nameof(Car.Year);
            _columnTrans.DataPropertyName = nameof(Car.Transmission);
            _columnDrive.DataPropertyName = nameof(Car.Drive);
            _columnHp.DataPropertyName = nameof(Car.Hp);
            _columnEngine.DataPropertyName = nameof(Car.Engine);
            _columnPrice.DataPropertyName = nameof(Car.Price);

            _viewModel = new CarsViewModel();
            //привязки текстбоксов цены
            _textBoxPriceFrom.DataBindings.Add("Text", _viewModel,
                nameof(CarsViewModel.PriceFrom), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxPriceTo.DataBindings.Add("Text", _viewModel,
                nameof(CarsViewModel.PriceTo), true, DataSourceUpdateMode.OnPropertyChanged);

            //заполняем данными DGV
            _model.Cars.ForEach(c => _bsCars.Add(c));
            //подписка на изменение цены
            _viewModel.PriceChanged += ViewModel_PriceChanged;
        }

        private void ViewModel_PriceChanged(object sender, (int from, int to) e)
        {
            _bsCars.Clear();

            _model.Cars.Where(c => CheckPrice(c.Price, e))
                       .ToList()
                       .ForEach(c => _bsCars.Add(c));
        }

        private bool CheckPrice(int price, (int from, int to) e)
        {
            if (e.to == 0)
            {
                return price >= e.from;
            }
            else if (e.from == 0)
            {
                return price <= e.to;
            }
            else
            {
                return price >= e.from && price <= e.to;
            }
        }
    }
}
