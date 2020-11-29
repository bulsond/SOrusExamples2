using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfUI.Models;
using WpfUI.ViewModels;

namespace WpfUI.Commands
{
    class SaveEmployeeCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public SaveEmployeeCommand(MainViewModel viewModel)
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
            //если редактируемый новый
            if (_viewModel.EditableEmployee.Id == 0)
            {
                //то добавляем его
                result = await _viewModel.EmployeeRepository
                                         .AddEmployee(_viewModel.EditableEmployee);
            }
            else
            {
                //иначе обновляем
                result = await _viewModel.EmployeeRepository
                                         .UpdateEmployee(_viewModel.EditableEmployee);
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
