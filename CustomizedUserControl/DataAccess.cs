using System;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedUserControl
{
    public class DataAccess
    {
        public static ProductModel GetProductModel(int productModelId)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Product.Size
                string sql = $@"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice
                                FROM Production.ProductModel
                                JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID
                                JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID
                                JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
                                WHERE Product.ProductModelID = {productModelId}
                                ORDER BY Product.ListPrice";
                ProductModel productModel = conn.Query<ProductModel>(sql).FirstOrDefault();               
                return productModel;
            }
        }

        public static List<Product> GetProducts(int productModelId)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT ProductId, Size FROM Production.Product
                                WHERE Product.ProductModelID = {productModelId}
                                ORDER BY Size";
                var products = conn.Query<Product>(sql).ToList();

                //Borrar valors duplicats amb C#
                var sizes = products.Distinct().ToList();

                return sizes;
            }
        }


        public static List<Product> getRandomId()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT Product.ProductModelID
                                FROM Production.Product;";
                List<Product> products = conn.Query<Product>(sql).ToList();
                return products;              
            }
        }
    }
}
