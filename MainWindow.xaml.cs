using System;
using System.Text;
using System.Windows;
using System.Collections.Generic; // Needed for List<T>

namespace Prog122_S24_L5_ClassesPtDuex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create an instance of an amazon order
            AmazonOrder order1 = new AmazonOrder("123478", "Will Cram", .1m);

            // Add 3 products
            order1.Products = new List<Product>(); // Initialize the list
            order1.Products.Add(new Product("Eternal Sunshine of a Spotless Mind", "Michele Gondry", 10, 14.00m));
            order1.Products.Add(new Product("El Dorado", "Howard Hawks", 10, 17.00m));
            order1.Products.Add(new Product("Robocop", "Paul Verrhoven", 10, 13.00m));

            StringBuilder sb = new StringBuilder(); // Use StringBuilder to build the text
            foreach (Product product in order1.Products)
            {
                sb.AppendLine($"Title: {product.Title}\nDirector: {product.Director}\n");
            }

            rtbDisplay.Document.Blocks.Clear();
            rtbDisplay.AppendText(sb.ToString());

            MessageBox.Show(order1.TotalPrice().ToString("c"));
        }

        public void ProductExample()
        {
            Product charlesMovie = new Product("El Darado", "Howard Hawks");

            charlesMovie.Title = "Mallrats";

            try
            {
                charlesMovie.Price = -5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } // class
} // namespace