using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataObjects;

namespace DataGridExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            ///Collection Initializer will act as a  data source for nested data grid
            #region Collection Initializer

            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    CustID =1, CustomerName="Dhawal Dhingra", CustomerAddress="Faridabad",CustomerOrders = new Orders()
                    {
                        new Order()
                        {
                            OrderID = 1, OrderQty=2,PricePerUnit=200, ProductDetails = new Product() {ProductID=1, ProductName="Nestle Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 2, OrderQty=2,PricePerUnit=100, ProductDetails = new Product() {ProductID=1, ProductName="Cadbury Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 3, OrderQty=2,PricePerUnit=150, ProductDetails = new Product() {ProductID=1, ProductName="Amul Butter",ProductTypeCode=20 }
                        }
                    }
                },
                new Customer()
                {
                    CustID =2, CustomerName="Himanshu Tomar", CustomerAddress="Malviya Nagar",CustomerOrders = new Orders()
                    {
                        new Order()
                        {
                            OrderID = 1, OrderQty=2,PricePerUnit=200, ProductDetails = new Product() {ProductID=1, ProductName="Nestle Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 2, OrderQty=2,PricePerUnit=100, ProductDetails = new Product() {ProductID=1, ProductName="Cadbury Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 3, OrderQty=2,PricePerUnit=150, ProductDetails = new Product() {ProductID=1, ProductName="Amul Butter",ProductTypeCode=20 }
                        }
                    }
                },
                new Customer()
                {
                    CustID =3, CustomerName="Hitasha Ahuja", CustomerAddress="Ashok Vihar",CustomerOrders = new Orders()
                    {
                        new Order()
                        {
                            OrderID = 1, OrderQty=2,PricePerUnit=200, ProductDetails = new Product() {ProductID=1, ProductName="Nestle Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 2, OrderQty=2,PricePerUnit=100, ProductDetails = new Product() {ProductID=1, ProductName="Cadbury Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 3, OrderQty=2,PricePerUnit=150, ProductDetails = new Product() {ProductID=1, ProductName="Amul Butter",ProductTypeCode=20 }
                        }
                    }
                },
                new Customer()
                {
                    CustID =1, CustomerName="Aishwarya Rawat", CustomerAddress="Aligarh",CustomerOrders = new Orders()
                    {
                        new Order()
                        {
                            OrderID = 1, OrderQty=2,PricePerUnit=200, ProductDetails = new Product() {ProductID=1, ProductName="Nestle Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 2, OrderQty=2,PricePerUnit=100, ProductDetails = new Product() {ProductID=1, ProductName="Cadbury Chocolate",ProductTypeCode=10 }
                        },
                        new Order()
                        {
                            OrderID = 3, OrderQty=2,PricePerUnit=150, ProductDetails = new Product() {ProductID=1, ProductName="Amul Butter",ProductTypeCode=20 }
                        }
                    }
                }

            };
            #endregion

            //Set data grid's context to the collection

            dtaGridNextedGrid.DataContext = customers;

        }
    }
}
