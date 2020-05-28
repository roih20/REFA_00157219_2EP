using System.Data;
using Npgsql;

namespace Parcial02
{
    public static class Conexion
    {
        private static string host = "127.0.0.1",
            Database = "Parcial 02",
            UserID = "postgres",
            password = "123456";

        private static string conexion =
            $"Server = {host}; Port = 5432; User ID = {UserID}; password = {password}; Database = {Database}";

        public static DataTable Consulta(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(conexion);
            DataSet ds = new DataSet();
            
            conn.Open(); 
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        public static void Accion(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(conexion);
            
            conn.Open();
            NpgsqlCommand command =  new NpgsqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}