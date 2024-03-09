using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_34._1_OOP_Incapsulation_Error
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.ShowProducr();

            List<Product> products = new List<Product>();

            for (int i = 0; i < cart.GetProducrCount(); i++)
            {
                products.Add(cart.GetProductByIndex(i));
            }

            products.RemoveAt(0);
            Console.WriteLine();
            cart.ShowProducr();

        }
    }

    class Cart
    {
        private List<Product> _products = new List<Product>();
        public Cart()
        {
            _products.Add(new Product("Apple"));
            _products.Add(new Product("Lime"));
            _products.Add(new Product("Cherry"));
            _products.Add(new Product("Pear"));
        }

        public void ShowProducr()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public int GetProducrCount()
        {
            return _products.Count;
        }

        public Product GetProductByIndex(int index)
        {
            return _products.ElementAt(index);
        }

    }

    class Product
    {
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}


//Example ТАК ДЕЛАТЬ НЕЛЬЗЯ

//static void Main(string[] args)
//{
//    Cart cart = new Cart();
//    cart.ShowProducr();

//    List<Product> products = cart._products; // Так делать нельзя

//    products.RemoveAt(0); // Так делать нельзя
//    Console.WriteLine();
//    cart.ShowProducr(); // Так делать нельзя

//}
//    }

//    class Cart
//{
//    public List<Product> _products { get; private set; } = new List<Product>(); // Так делать нельзя
//    public Cart()
//    {
//        _products.Add(new Product("Apple"));
//        _products.Add(new Product("Lime"));
//        _products.Add(new Product("Cherry"));
//        _products.Add(new Product("Pear"));
//    }

//    public void ShowProducr()
//    {
//        foreach (Product product in _products)
//        {
//            Console.WriteLine(product.Name);
//        }
//    }

//}

//class Product
//{
//    public string Name { get; private set; }

//    public Product(string name)
//    {
//        Name = name;
//    }
//}
