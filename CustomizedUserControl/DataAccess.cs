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
                string sql = $"exec sp1_getProductModel {productModelId}";
                ProductModel productModel = conn.Query<ProductModel>(sql).FirstOrDefault();               
                return productModel;
            }
        }

        public static List<Product> GetProducts(int productModelId)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"exec sp2_getProduct {productModelId}";
                var products = conn.Query<Product>(sql).ToList();

                List<Product> sizes = new List<Product>();
                List<string> test = new List<string>();

                for (int i = 0; i < products.Count; i++)
                {
                    Product p = products[i];
                    string a = p.Size;

                    if (!test.Contains(a))
                    {
                        test.Add(a);
                        sizes.Add(p);
                    }
                }
                return sizes;
            }
        }


        public static List<Product> getRandomId()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "exec sp3_getProductModelIds";
                List<Product> products = conn.Query<Product>(sql).ToList();
                return products;
            }
        }
    }
}
