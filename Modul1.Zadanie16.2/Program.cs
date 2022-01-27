using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Modul1.Zadanie16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empty - пустые кавычки
            string jsonString = String.Empty;  
            using (StreamReader sr = new StreamReader("../../../Product.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            // перевод строки jsonString в массив <Product[]>
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.priceProduct > maxProduct.priceProduct)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine($"{maxProduct.codeProduct} {maxProduct.nameProduct} {maxProduct.priceProduct}");
            Console.ReadKey();
        }
    }
}
