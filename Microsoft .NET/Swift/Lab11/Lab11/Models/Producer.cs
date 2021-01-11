using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class Producer
    {
        private static readonly string _selectProducersCommand = @"SELECT [id], [FirstName],[LastName] FROM [DB_dotNet].[dbo].[Producer]";
        private static readonly string _insertProducerCommand = @"INSERT INTO [DB_dotNet].[dbo].[Producer] VALUES (@firstName,@lastName)";
        private static readonly string _updateProducerCommand = @"UPDATE [DB_dotNet].[dbo].[Producer] set  [FirstName] = @firstName,[LastName]  = @lastName  WHERE [id] = @id";
        private static readonly string _deleteProducerCommand = @"DELETE FROM [DB_dotNet].[dbo].[Producer] WHERE [id] = @id";
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static List<Producer> List(SqlConnection connection)
        {
            List<Producer> Produssers = new List<Producer>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectProducersCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Producer producer = new Producer
                        {
                            Id = (int)reader["id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                        };
                        Produssers.Add(producer);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return Produssers;
        }

        public static void Insert(SqlConnection connection, Producer producer)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertProducerCommand;
                    command.CommandType = CommandType.Text;              
                   
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 32).Value = producer.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 32).Value = producer.LastName;
  
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Producer producer)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateProducerCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = producer.Id;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 32).Value = producer.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 32).Value = producer.LastName;
            
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int ProducerId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteProducerCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = ProducerId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
