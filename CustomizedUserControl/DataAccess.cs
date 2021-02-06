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
        static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        //Methods to get data from database with stored procedures.
        public static ProductModel GetProductModel(int productModelId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"exec sp1_getProductModel {productModelId}";
                ProductModel productModel = conn.Query<ProductModel>(sql).FirstOrDefault();               
                return productModel;
            }
        }

        //In this method we have a control to remove duplicated values.
        public static List<Product> GetProducts(int productModelId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"exec sp2_getProduct {productModelId}";
                var products = conn.Query<Product>(sql).ToList();

                //Declare 2 auxiliar lists, one for the sizes as string, and another for the Products with non duplicaded values.
                List<Product> sizes = new List<Product>();
                List<string> test = new List<string>();

                for (int i = 0; i < products.Count; i++)
                {
                    //We recieve a product and set its Size into a string
                    Product p = products[i];
                    string a = p.Size;
                    
                    //if the string value is not in the test list, we add it the string, and also add the Product object to the auxiliar Product List
                    //if the string value is already in the list, we dont add anything.
                    if (!test.Contains(a))
                    {
                        test.Add(a);
                        sizes.Add(p);
                    }
                    //Finally we return the new List with non duplicated values.
                }
                return sizes;
            }
        }

        public static List<Product> getRandomId()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "exec sp3_getProductModelIds";
                List<Product> products = conn.Query<Product>(sql).ToList();
                return products;
            }
        }
    }
}
