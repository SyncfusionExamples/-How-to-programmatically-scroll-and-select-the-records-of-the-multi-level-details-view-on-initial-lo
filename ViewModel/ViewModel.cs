using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_MVVM
{
    public class ViewModel
    {
        ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public ViewModel()
        {
            this.GenerateSales();
            this.GenerateOrders();
            _employees = GetEmployeesDetails();
        }

        public ObservableCollection<Employee> GetEmployeesDetails()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { EmployeeID = 1, OrderID = 1001, City = "Berlin", Orders = GetOrders(1001) });
            employees.Add(new Employee() { EmployeeID = 2, OrderID = 1002, City = "Mexico D.F.", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 3, OrderID = 1003, City = "London", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 4, OrderID = 1004, City = "BERGS", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 5, OrderID = 1005, City = "Mannheim", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 6, OrderID = 1006, City = "Glasgow", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 7, OrderID = 1007, City = "Newcastle", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 8, OrderID = 1008, City = "Paris", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 9, OrderID = 1009, City = "Mannheim", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 10, OrderID = 1010, City = "Jaipur", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 11, OrderID = 1011, City = "Belgrade", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 12, OrderID = 1012, City = "Recife", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 13, OrderID = 1013, City = "Kampala", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 14, OrderID = 1014, City = "Birmingham", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 15, OrderID = 1015, City = "Naples", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 16, OrderID = 1016, City = "Warsaw", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 17, OrderID = 1017, City = "Frankfurt", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 18, OrderID = 1018, City = "Ljubljana", Orders = GetOrders(1002) });
            employees.Add(new Employee() { EmployeeID = 19, OrderID = 1019, City = "Reykjavik", Orders = GetOrders(1002) });
            return employees;
        }

        //Orders collection is initialized here.
        ObservableCollection<OrderInfo> Orders = new ObservableCollection<OrderInfo>();

        public void GenerateOrders()
        {
            Orders.Add(new OrderInfo() { OrderID = 1001, Quantity = 10, Sales = GetSales(1001) });
            Orders.Add(new OrderInfo() { OrderID = 1001, Quantity = 10, Sales = GetSales(1001) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 0, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 1, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 2, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 3, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 4, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 5, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 6, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 7, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 8, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 9, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 10, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 11, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 12, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 13, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 14, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 15, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 16, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 17, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 18, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 19, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 20, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 21, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 22, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 23, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 24, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 25, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 26, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 27, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 28, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 29, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 30, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 31, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 32, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 33, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 34, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 35, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 36, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 37, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 38, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 39, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 40, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 41, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 42, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 43, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 44, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 45, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 46, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 47, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 48, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 49, Sales = GetSales(1002) });
            Orders.Add(new OrderInfo() { OrderID = 1003, Quantity = 50, Sales = GetSales(1003) });
            Orders.Add(new OrderInfo() { OrderID = 1004, Quantity = 70, Sales = GetSales(1004) });
            Orders.Add(new OrderInfo() { OrderID = 1005, Quantity = 20, Sales = GetSales(1005) });
            Orders.Add(new OrderInfo() { OrderID = 1005, Quantity = 20, Sales = GetSales(1005) });
        }

        private ObservableCollection<OrderInfo> GetOrders(int orderID)
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();

            foreach (var order in Orders)

                if (order.OrderID == orderID)
                    orders.Add(order);
            return orders;
        }

        //Sales collection is initialized here.
        ObservableCollection<SalesInfo> Sales = new ObservableCollection<SalesInfo>();

        public void GenerateSales()
        {
            Sales.Add(new SalesInfo() { OrderID = 1001, SalesID = "A00001", ProductName = "Bike1" });
            Sales.Add(new SalesInfo() { OrderID = 1001, SalesID = "A00002", ProductName = "Bike1" });
            Sales.Add(new SalesInfo() { OrderID = 1002, SalesID = "A00003", ProductName = "Cycle" });
            Sales.Add(new SalesInfo() { OrderID = 1002, SalesID = "A20003", ProductName = "Cycle 1" });
            Sales.Add(new SalesInfo() { OrderID = 1002, SalesID = "A20003", ProductName = "Cycle 2" });
            Sales.Add(new SalesInfo() { OrderID = 1002, SalesID = "A20003", ProductName = "Cycle 3" });
            Sales.Add(new SalesInfo() { OrderID = 1002, SalesID = "A20003", ProductName = "Cycle 4" });
            Sales.Add(new SalesInfo() { OrderID = 1003, SalesID = "A00004", ProductName = "Car" });
        }

        private ObservableCollection<SalesInfo> GetSales(int orderID)
        {
            ObservableCollection<SalesInfo> sales = new ObservableCollection<SalesInfo>();

            foreach (var sale in Sales)

                if (sale.OrderID == orderID)
                    sales.Add(sale);
            return sales;
        }
    }
}
