using System;
using System.Linq;
using System.Windows.Input;
using WpfUI.ViewModels;

namespace WpfUI.Commands
{
    class SelectNextCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public SelectNextCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_viewModel.SelectedEmployee is null)
            {
                _viewModel.SelectedEmployee = _viewModel.People.First();
                return;
            }
            int nextOrderNumber = _viewModel.SelectedEmployee.OrderNumber + 1;
            if (nextOrderNumber > _viewModel.People.Max(p => p.OrderNumber))
            {
                return;
            }

            _viewModel.SelectedEmployee = _viewModel.People.First(p => p.OrderNumber == nextOrderNumber);
        }
    }
}
