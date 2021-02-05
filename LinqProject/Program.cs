using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
               new Category {CategoryId=1,CategoryName="Bilgisayar"},
               new Category {CategoryId=2,CategoryName="Telefon"},
            };
            List<Product> products = new List<Product> 
            {
             new Product {CategoryId=1,ProductId=1 ,ProductName="Acer Laptop",QuantityPerUnit="32GB RAM",UnitPrice =100000,UnitsInStock=5},
             new Product {CategoryId=1,ProductId=2 ,ProductName="Asus Laptop",QuantityPerUnit="16GB RAM",UnitPrice =8000,UnitsInStock=3},
             new Product {CategoryId=1,ProductId=3 ,ProductName="HP Laptop",QuantityPerUnit="8GB RAM",UnitPrice =6000,UnitsInStock=2},
             new Product {CategoryId=2,ProductId=4 ,ProductName="Samsung Telefon",QuantityPerUnit="4GB RAM",UnitPrice =5000,UnitsInStock=15},
             new Product {CategoryId=2,ProductId=5 ,ProductName="Apple Telefon",QuantityPerUnit="4GB RAM",UnitPrice =8000,UnitsInStock=0},
            };
            Console.WriteLine("Algoritmik--------------------------------------------------------");
            
            foreach (var product in products)
            {
                if (product.UnitPrice>5000 && product.UnitsInStock>3)
                {
                    Console.WriteLine(product.ProductName);
                }        
            }

            Console.WriteLine("Linq--------------------------------------------------------------");

            //Where bir 
            var result = products.Where(products => products.UnitPrice>5000 && products.UnitsInStock > 3);
            
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);


        }
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts= new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product)
                }
            }
            return filteredProducts;
        }
        //Linq kullanımı 
        static List<Product> GetProductsLinq(List<Product> products)
        {
            //Linq sistemi wher ile koşullar yazılır filtreleme yapılır
            return products.Where(products => products.UnitPrice > 5000 && products.UnitsInStock > 3).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName{ get; set; }
    }
}
