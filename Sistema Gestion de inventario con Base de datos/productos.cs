using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    internal class productos : conexionBD
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public int categoria { get; set; }
        public string descripcion { get; set; }



        public productos(string nom, float prec, int sto, int cat, string desc)
        {
            this.nombre = nom;
            this.precio = prec;
            this.stock = sto;
            this.categoria = cat;
            this.descripcion = desc;
        }

        public productos(int id,string nom, float prec, int sto, int cat, string desc)
        {
            this.id = id;
            this.nombre = nom;
            this.precio = prec;
            this.stock = sto;
            this.categoria = cat;
            this.descripcion = desc;
        }

        public productos() { }


        public DataTable getProds()
        {
            try
            {
                if (AbrirConexion() == true)
                {

                    string consulta = "SELECT productos.nombre_producto, productos.precio_producto, productos.stock_producto,\r\n(SELECT categorias.nombre_categoria FROM categorias\r\nWHERE productos.categoria_producto=categorias.id_categoria) as 'Categoria', productos.descripcion_producto\r\nFROM productos";
                    MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());
                    DataTable dt = new DataTable();

                    MySqlDataAdapter dt2 = new MySqlDataAdapter(cmd);
                    dt2.Fill(dt);
                    return dt;

                }
                else
                {
                    return null;
                }
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

        public DataTable getProdBajoSt()
        {
            try
            {
                AbrirConexion();
                string consulta = "SELECT productos.nombre_producto, productos.precio_producto, productos.stock_producto,\r\n(SELECT categorias.nombre_categoria FROM categorias WHERE productos.categoria_producto=categorias.id_categoria) as 'Categoria',\r\nproductos.descripcion_producto \r\nFROM productos \r\nWHERE productos.stock_producto<=10";
                MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null ;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable getProdCat(int idCat)
        {
            try
            {
                AbrirConexion();
                string consulta = "SELECT productos.nombre_producto, productos.precio_producto, productos.stock_producto,\r\n(SELECT categorias.nombre_categoria FROM categorias WHERE productos.categoria_producto=categorias.id_categoria) as 'Categoria',\r\nproductos.descripcion_producto FROM productos\r\nWHERE productos.categoria_producto=@idCat";
                MySqlCommand cmd = new MySqlCommand(consulta,GetConexion());

                cmd.Parameters.AddWithValue("@idCat",idCat);

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

        public Boolean actualizarProd(productos prod, int id)
        {
            try
            {
                AbrirConexion();
                string consulta = "UPDATE productos\r\nSET productos.nombre_producto= @nombre,\r\nproductos.precio_producto= @precio,\r\nproductos.stock_producto= @stock,\r\nproductos.categoria_producto= @categoria,\r\nproductos.descripcion_producto= @desc\r\nWHERE productos.id_producto=@id_prod";
                MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());

                cmd.Parameters.AddWithValue("@nombre", prod.nombre);
                cmd.Parameters.AddWithValue("@precio", prod.precio);
                cmd.Parameters.AddWithValue("@stock", prod.stock);
                cmd.Parameters.AddWithValue("@categoria", prod.categoria);
                cmd.Parameters.AddWithValue("@desc", prod.descripcion);
                cmd.Parameters.AddWithValue("@id_prod", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public productos buscarProd(int id)
        {
            try
            {
                AbrirConexion();
                string consulta = "SELECT * FROM productos WHERE productos.id_producto=@id;";
                MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());
                cmd.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                MySqlDataAdapter dataAd = new MySqlDataAdapter(cmd);
                dataAd.Fill(dt);

                productos prodEncontrado = new productos(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString(), float.Parse(dt.Rows[0].ItemArray[2].ToString()),
                    int.Parse(dt.Rows[0].ItemArray[3].ToString()), int.Parse(dt.Rows[0].ItemArray[4].ToString()), dt.Rows[0].ItemArray[5].ToString());

                return prodEncontrado;
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

        public DataTable buscarProd(string nom)
        {
            try
            {
                AbrirConexion();
                string consulta = "SELECT * FROM productos WHERE productos.nombre_producto LIKE concat('%',@nombre,'%')";
                MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());
                cmd.Parameters.AddWithValue("@nombre", nom);
                DataTable dt = new DataTable();
                MySqlDataAdapter dataAd = new MySqlDataAdapter(cmd);
                dataAd.Fill(dt);

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

        public Boolean agregarProd(productos prod)
        {
            try
            {
                AbrirConexion();
                string consulta = "INSERT INTO productos (nombre_producto, precio_producto, stock_producto, categoria_producto, descripcion_producto) \r\nVALUES ('" + prod.nombre + "'," + prod.precio + "," + prod.stock + "," + prod.categoria + ",'" + prod.descripcion + "')";
                MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se ha ingresado correctamente el usuario");
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public Boolean borrarProd(int id)
        {
            try
            {
                AbrirConexion();
                string consulta = "DELETE from productos\r\nWHERE productos.id_producto=@id";
                MySqlCommand cmd = new MySqlCommand(consulta, GetConexion());

                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }


        }

    }
}
