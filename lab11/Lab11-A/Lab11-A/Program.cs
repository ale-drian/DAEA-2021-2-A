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
            ////5.	Usa el método Select para proyectar las propiedades Product.Name y Product.ProductID en una secuencia de tipos anónimos
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from product in context.Product
            //                select new
            //                {
            //                    ProductId = product.ProductID,
            //                    ProductName = product.Name
            //                };

            //    Console.WriteLine("Información de Productos:");
            //    foreach (var productInfo in query)
            //    {
            //        Console.WriteLine("Product Id: {0} Product name: {1} ",
            //            productInfo.ProductId, productInfo.ProductName);
            //    }
            //    Console.ReadKey();
            //}
            ////8.	Se devuelven los pedidos en los que la cantidad de pedido es superior a 2 e inferior a 6
            //int orderQtyMin = 2;
            //int orderQtyMax = 6;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from order in context.SalesOrderDetail
            //                where order.OrderQty > orderQtyMin
            //                && order.OrderQty < orderQtyMax
            //                select new
            //                {
            //                    SalesOrderID = order.SalesOrderID,
            //                    OrderQty = order.OrderQty
            //                };

            //    Console.WriteLine("Pedidos con cantidad mayor a 2 y menor a 6:");
            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Order Id: {0} Order Quantity: {1} ",
            //            order.SalesOrderID, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}

            ////9.	Se devuelven todos los productos de color rojo
            //String color = "Red";
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from product in context.Product
            //                where product.Color == color
            //                select new
            //                {
            //                    ProductName = product.Name,
            //                    ProductNumber = product.ProductNumber,
            //                    ListPrice = product.ListPrice                                
            //                };

            //    Console.WriteLine("Productos rojos:");
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Name: {0}", product.ProductName);
            //        Console.WriteLine("Product number: {0}", product.ProductNumber);
            //        Console.WriteLine("List price: {0}", product.ListPrice);
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            ////10.	Usa una matriz como parte de una cláusula Where…Contains para encontrar todos los productos que tienen un ProductModelID que coincide con un valor de la matriz
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    int?[] productModelIds = { 19, 26, 118 };
            //    var query = from product in context.Product
            //                where productModelIds.Contains(product.ProductModelID)
            //                select product;

            //    Console.WriteLine("Productos con ModelID 19, 26 o 118:");
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("{0}: {1}", product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            ////12.	Utiliza orderby… descending, que es equivalente al método OrderByDescending, para ordenar el precio de venta de mayor a menor
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{

            //    IQueryable<Decimal> sortedPrices = from p in context.Product
            //                                       orderby p.ListPrice descending
            //                                       select p.ListPrice;

            //    Console.WriteLine("Lista de precios del mas alto al mas bajo:");
            //    foreach (Decimal price in sortedPrices)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    Console.ReadKey();
            //}

            //14.	Usa el método Average para encontrar el precio de venta promedio de los productos de cada estilo
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from product in context.Product
            //                group product by product.Style into g
            //                select new { 
            //                    Style = g.Key,
            //                    AverageListPrice = g.Average(product => product.ListPrice)
            //                };

            //    Console.WriteLine("Promedio de precios de Productos con el mismo estilo:");
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Estilo: {0} Precio promedio {1}", 
            //            product.Style, product.AverageListPrice);
            //    }
            //    Console.ReadKey();
            //}

            //15.	Se agrupan los productos por colores y se utiliza Count para devolver el número de productos de cada grupo de color
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from product in context.Product
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };

                Console.WriteLine("Cantidad de productos por color:");
                foreach (var product in query)
                {
                    Console.WriteLine("Color = {0} \t Cantidad = {1}",
                        product.Color, product.ProductCount);
                }
                Console.ReadKey();
            }
        }
    }
}
