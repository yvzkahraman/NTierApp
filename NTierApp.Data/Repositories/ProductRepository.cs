using NTierApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Data.Repositories
{
    // product ile ilgili database işlemlerinden sorumlu.
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>(); 
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database= SampleDb; integrated security = true;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Product";

            connection.Open();

             var reader =  cmd.ExecuteReader();
            while(reader.Read())
            {
                var product = new Product();

                product.Id = reader.GetInt32(0);
                product.Name = reader.GetString(1);
                product.Price = reader.GetInt64(2);

                products.Add(product);

            }

            connection.Close();
            reader.Close();

            return products;
        }
    }
}
