using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BiblioTP3
{
    public class ClienteDAO
    {
        private static string connectionString;
        private SqlConnection connection;

        static ClienteDAO()
        {
            connectionString = @"Server = .; Database = ClientesDataBase; Trusted_Connection = True";
        }

        public ClienteDAO()
        {
            connection = new SqlConnection(ClienteDAO.connectionString);
        }

        /// <summary>
        /// Guardara los campos de un cliente determinado en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public void GuardarClienteEnBaseDeDatos(Cliente cliente)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Clientes (dni, nombre, apellido, metodoPago) VALUES (@dni, @nombre, @apellido, @metodoPago)";

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.AddWithValue("dni", cliente.Dni);
                sqlCommand.Parameters.AddWithValue("nombre", cliente.Nombre);
                sqlCommand.Parameters.AddWithValue("apellido", cliente.Apellido);
                sqlCommand.Parameters.AddWithValue("metodoPago", cliente.MetodoPago);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Leera una base de datos 
        /// </summary>
        /// <returns>Retornara una lista de clientes, con los datos que se encontraban en la DataBase</returns>
        public List<Cliente> LeerClientesDesdeBaseDeDatos()
        {
            List<Cliente> clientesLista = new List<Cliente>();
            try
            {
                string query = "SELECT * FROM Clientes";

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int dni = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2); 
                    string metodoPago = dataReader.GetString(3);

                    Cliente nuevoCliente = new Cliente(nombre, apellido, metodoPago, dni);

                    clientesLista.Add(nuevoCliente);
                }

                return clientesLista;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Eliminara los datos de un cliente dentro de la DataBase
        /// </summary>
        /// <param name="cliente"></param>
        public void EliminarClienteSeleccionadoBD(Cliente cliente)
        {
            try
            {
                string query = "DELETE FROM Clientes WHERE dni = @dni";

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.AddWithValue("dni", cliente.Dni);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
