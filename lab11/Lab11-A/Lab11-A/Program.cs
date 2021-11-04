using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.	Sintaxis de expresiones de consulta
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities()) {
            //    var products = AWEntities.Product;

            //    IQueryable<string> productNames = from p in products
            //                                      select p.Name;
            //    Console.WriteLine("Productos:");
            //    foreach (var productName in productNames) {
            //        Console.WriteLine(productName);
            //    }
            //    Console.ReadKey();
            //}

            ////2.	Sintaxis de consultas basadas en métodos
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    var products = AWEntities.Product;

            //    IQueryable<string> productNames = products.Select(p => p.Name);

            //    Console.WriteLine("Productos:");
            //    foreach (var productName in productNames)
            //    {
            //        Console.WriteLine(productName);
            //    }
            //    Console.ReadKey();
            //}

            //3. Listar todos los productos de tamaño “L”:
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    var products = AWEntities.Product;

            //    IQueryable<Product> productLarge = products.Where(p => p.Size == "L");

            //    Console.WriteLine("Productos:");
            //    foreach (var product in productLarge)
            //    {
            //        Console.WriteLine(product.Name);
            //    }
            //    Console.ReadKey();
            //}

            ////4. devolver todas las filas de la tabla Product y mostrar los nombres de producto
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    IQueryable<Product> productQuery = context.Product;

            //    Console.WriteLine("Productos:");
            //    foreach (var product in productQuery)
            //    {
            //        Console.WriteLine(product.Name);
            //    }
            //    Console.ReadKey();
            //}
            //5.	Usa el método Select para proyectar las propiedades Product.Name y Product.ProductID en una secuencia de tipos anónimos
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from product in context.Product
                            select new
                            {
                                ProductId = product.ProductID,
                                ProductName = product.Name
                            };

                Console.WriteLine("Información de Productos:");
                foreach (var productInfo in query)
                {
                    Console.WriteLine("Product Id: {0} Product name: {1} ",
                        productInfo.ProductId, productInfo.ProductName);
                }
                Console.ReadKey();
            }
        }
    }
}
