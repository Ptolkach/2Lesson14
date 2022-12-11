using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Соленые огурцы",
                ProductPrice = 150,
                ProductImage = "Data\\cucumber.png",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                ProductPrice = 100,
                ProductImage = "Data\\milk.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Блендер",
                ProductPrice = 1500,
                ProductImage = "Data\\blender.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                ProductPrice = 5000,
                ProductImage = "Data\\micro.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Сельдь",
                ProductPrice = 250,
                ProductImage = "Data\\fish.jpg",
                ProductCategory = ProductCategories.Food
            });
            lstBox.ItemsSource = products;
        }
    }
}
