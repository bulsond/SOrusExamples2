using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfUI.Models;
using WpfUI.ViewModels;

namespace WpfUI.Commands
{
    class AddEmployeeCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public AddEmployeeCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.EditableEmployee = new Employee(0);
            _viewModel.SelectedEmployee = null;
        }
    }
}
