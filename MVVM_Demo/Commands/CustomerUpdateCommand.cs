using MVVM_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM_Demo.Commands
{
    internal class CustomerUpdateCommand: ICommand
    {
    private CustomerViewModel _viewModel;

        /// <summary>
        /// initializes a new instance of the CustomerUpdateCommand
        /// </summary>
        /// <param name="viewModel"></param>
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _viewModel.SaveChanges();
        }
    }
}
