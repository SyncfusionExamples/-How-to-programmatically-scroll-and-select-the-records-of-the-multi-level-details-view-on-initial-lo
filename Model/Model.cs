using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_MVVM
{
    public class SalesInfo : INotifyPropertyChanged
    {
        private int _orderID;
        private string _salesID;
        private string _productName;

        public int OrderID
        {
            get { return _orderID; }
            set
            {
                _orderID = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string SalesID
        {
            get { return _salesID; }
            set
            {
                _salesID = value;
                OnPropertyChanged("SalesID");
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderId;
        private int _quantity;
        private ObservableCollection<SalesInfo> _sales;

        public ObservableCollection<SalesInfo> Sales
        {
            get { return _sales; }
            set
            {
                _sales = value;
                OnPropertyChanged("Sales");
            }
        }

        public int OrderID
        {
            get { return orderId; }
            set
            {
                orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class Employee : INotifyPropertyChanged
    {
        private int _EmployeeID;
        private int _orderId;
        private string _city;
        private ObservableCollection<OrderInfo> _orders;

        public int EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                OnPropertyChanged("EmployeeID");
            }
        }

        public int OrderID
        {
            get { return this._orderId; }
            set
            {
                this._orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

      

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
