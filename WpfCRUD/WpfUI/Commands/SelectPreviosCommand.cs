using System;
using System.Linq;
using System.Windows.Input;
using WpfUI.ViewModels;

namespace WpfUI.Commands
{
    class SelectPreviosCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public SelectPreviosCommand(MainViewModel viewModel)
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
                _viewModel.SelectedEmployee = _viewModel.People.Last();
                return;
            }
            int prevOrderNumber = _viewModel.SelectedEmployee.OrderNumber - 1;
            if (prevOrderNumber < 1)
            {
                return;
            }

            _viewModel.SelectedEmployee = _viewModel.People.First(p => p.OrderNumber == prevOrderNumber);
        }
    }
}
