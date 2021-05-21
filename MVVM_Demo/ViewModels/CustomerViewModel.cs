
using MVVM_Demo.Commands;
using MVVM_Demo.Models;
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MVVM_Demo.ViewModels
{
    internal class CustomerViewModel
    {
        private Customer _Customer;
        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }

        /// <summary>
        /// initializes a new instance of the CustomerViewModel class
        /// The contructor is normally used to get data from a db or xml or restApi ...
        /// in this example, we are just passing a value to the _Customer
        /// </summary>
        public CustomerViewModel()
        {
            _Customer = new Customer("Anas");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        /// <summary>
        /// Gets or sets a system boolean value for whether and the customer can be updated.
        /// </summary>
        /// <returns></returns>
        internal bool CanUpdate { get; set; }

        /// <summary>
        /// Saves changes made to the customer instance.
        /// </summary>
        public void SaveChanges()
        {
            Debug.Assert(false, "The customer has been changed to " + Customer.Name);
        }

        /// <summary>
        /// Gets the update command for the view model
        /// </summary>
        public ICommand UpdateCommand
        {
            get;
            private set;
        }
    }
}
