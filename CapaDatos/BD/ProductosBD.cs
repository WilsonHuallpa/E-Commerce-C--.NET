using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos.Exeption;

namespace CapaDatos.BD
{
    public static class ProductosBD
    {
        static string cadenaDeConexion = "data source = DESKTOP-JOPMB0N ;initial catalog = kwik-e-mart; integrated security = true ";
        static SqlCommand comando;
        static SqlConnection conexion;

        static ProductosBD()
        {
            conexion = new SqlConnection(cadenaDeConexion);
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }


        public static bool Guardar(Producto p)
        {
            string sql = String.Format("Insert into productos(descripcion,precio,stock,tipo) values('{0}','{1}','{2}','{3}')", p.Descripcion, p.Precio, p.Stock, p.TipoProducto.ToString());
            return EjecutarNonQuery(sql);
        }

        public static List<Producto> Leer()
        {
            List<Producto> list = new List<Producto>();
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * From productos";

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                SqlDataReader datosDevueltos = comando.ExecuteReader();
                while (datosDevueltos.Read())
                {
                    switch (datosDevueltos["tipo"].ToString())
                    {
                        case "perecedero":
                            list.Add(new ProductoPerecedero(datosDevueltos["descripcion"].ToString(), 
                                                    int.Parse(datosDevueltos["id"].ToString()),
                                                    double.Parse(datosDevueltos["precio"].ToString()),
                                                    int.Parse(datosDevueltos["stock"].ToString()),
                                                    Producto.ETipo.perecedero));
                            break;
                        case "noPerecedero":
                            list.Add(new ProductoNoPerecedero (datosDevueltos["descripcion"].ToString(),
                                                  int.Parse(datosDevueltos["id"].ToString()),
                                                  double.Parse(datosDevueltos["precio"].ToString()),
                                                  int.Parse(datosDevueltos["stock"].ToString()),
                                                  Producto.ETipo.noPerecedero));
                            break;
                        case "almacen":
                            list.Add(new ProductoAlmacen(datosDevueltos["descripcion"].ToString(),
                                                  int.Parse(datosDevueltos["id"].ToString()),
                                                  double.Parse(datosDevueltos["precio"].ToString()),
                                                  int.Parse(datosDevueltos["stock"].ToString()),
                                                  Producto.ETipo.almacen));
                            break;
                    }
                }
                datosDevueltos.Close();
            }
            catch (Exception e)
            {
                throw new Exception("ERROR al cargar Leer dato :" + e.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                comando.CommandText = sql;
                conexion.Open();
                comando.ExecuteNonQuery();
                todoOk = true;
            }
            catch (Exception ex)
            {
                throw new BaseDeDatoException("Error de Base de datos" + ex.Message);
                //todoOk = false;
            }
            finally
            {
                ProductosBD.conexion.Close();
            }
            return todoOk;
        }
    }
}
