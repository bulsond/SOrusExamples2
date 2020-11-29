using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfUI.Models;
using WpfUI.ViewModels;

namespace WpfUI.Commands
{
    class DeleteEmployeeCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public DeleteEmployeeCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            int result = 0;
            if (_viewModel.SelectedEmployee != null)
            {
                result = await _viewModel.EmployeeRepository
                                         .RemoveEmployee(_viewModel.SelectedEmployee.Id);
            }

            if (result > 0)
            {
                _viewModel.EditableEmployee = new Employee(0);
                await _viewModel.LoadPeople();
            }
            else
            {
                //в случае неудачи...
            }
        }
    }
}
