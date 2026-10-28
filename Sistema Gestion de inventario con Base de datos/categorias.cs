using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    internal class categorias:conexionBD
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public categorias() 
        {
        
        }

        public DataTable getCategorias()
        {
            try
            {
                AbrirConexion();
                string consulta = "SELECT categorias.id_categoria, categorias.nombre_categoria FROM categorias";
                MySqlCommand cmd = new MySqlCommand(consulta,GetConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                CerrarConexion();
            }

        }


    }
}
