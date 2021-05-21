using System.ComponentModel;

namespace MVVM_Demo.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private string _Name;

        /// <summary>
        /// Gets or sets the customer's name
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value; 
                OnPropertyChanged("Name");
            }
        }



        /// <summary>
        /// initializes a new instance of the customer class;
        /// </summary>
        public Customer(string Name)
        {
            this.Name = Name;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
