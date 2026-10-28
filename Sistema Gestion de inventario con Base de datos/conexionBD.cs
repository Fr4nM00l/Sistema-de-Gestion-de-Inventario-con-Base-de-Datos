using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    internal class conexionBD
    {
        private readonly string connectionString = "Server=localhost;Database=inventario;Uid=root;Pwd=;";
        private MySqlConnection connection;

        public conexionBD()
        {
            connection = new MySqlConnection(connectionString);
        }

        public bool AbrirConexion()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                return false;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
            }
        }

        public MySqlConnection GetConexion()
        {
            return connection;
        }
    }
}
