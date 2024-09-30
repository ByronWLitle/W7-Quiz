using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static W7_Quiz.Program;

namespace W7_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            ShoppingCart cart = new ShoppingCart();
            Console.WriteLine("Store System");
            Console.WriteLine("-------------");
            while (selection != 4)
            {
                Console.WriteLine("Press 1 to add a product, 2 to remove a product, 3 to calculate total price, 4 to exit program.");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        cart.AddProduct();
                        break;
                    case 2:
                        Console.Write("Give us the product's ID to remove from cart: ");
                        string productID = Console.ReadLine();
                        cart.RemoveProduct(productID);
                        break;
                    case 3:
                        cart.CalculateTotalPrice();
                        break;
                    case 4:
                        break;
                }
            }
            Console.WriteLine("Program complete");
            Console.ReadLine();
        }
        public class Product
        {
            public string ProductID = "";
            public string ProductName = "";
            public double Price = 0;
        }
        public class ShoppingCart
        {
            List<Product> product = new List<Product>();
            public void AddProduct(Product product)
            {
                string aProductID = "";
                string aProductName = "";
                double aProductPrice = 0;
                Console.Write("Enter Product ID: ");
                aProductID = Console.ReadLine();
                Console.Write("Enter Product Name: ");
                aProductName = Console.ReadLine();
                Console.Write("Enter Product's Price: ");
                aProductPrice = Convert.ToDouble(Console.ReadLine());
                new Product() { ProductID = aProductID, ProductName = aProductName, Price = aProductPrice };
            }
            public void RemoveProduct(string productID)
            {
                if (productID == product.Contains(productID))
                {
                    product.Remove(productID);
                }
                else
                {
                    Console.WriteLine("Invalid entry, please try again");
                    RemoveProduct(productID);
                }
            }
            public void CalculateTotalPrice()
            {
                foreach (var price in product)
                {

                }
            }
        }
    }
}
