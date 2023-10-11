using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DProduct
    {
        public static string connectionString = "Data Source=LAB1504-19\\SQLEXPRESS;Initial Catalog=FacturaDB;User ID=userTecsup;Password=123456";
        public List<Product> Get()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para seleccionar datos
                string query = "ListarProductos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos de cada fila
                                products.Add(new Product
                                {
                                    Product_Id = (int)reader["product_id"],
                                    Name = reader["name"].ToString(),
                                    Price = (double)reader["price"],
                                    Stock = (int)reader["stock"],
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();

            }
            return products;
        }
    }
}