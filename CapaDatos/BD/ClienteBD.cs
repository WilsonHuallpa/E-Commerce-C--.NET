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
    public static class ClienteBD
    {
        static string cadenaDeConexion = "data source = DESKTOP-JOPMB0N ;initial catalog = kwik-e-mart; integrated security = true ";
        static SqlCommand comando;
        static SqlConnection conexion;

        static ClienteBD()
        {
            conexion = new SqlConnection(cadenaDeConexion);
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }


        public static bool Guardar(Cliente auxCliente)
        {
            string sql = String.Format("Insert into clientes(nombre,apellido,dni) values('{0}','{1}','{2}')", auxCliente.Nombre, auxCliente.Apellido,auxCliente.Dni.ToString());
            return EjecutarNonQuery(sql);
        }

        public static List<Cliente> Leer()
        {
            List<Cliente> list = new List<Cliente>();
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * From clientes";

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                SqlDataReader datosDevueltos = comando.ExecuteReader();
                while (datosDevueltos.Read())
                {
                    list.Add(new Cliente(datosDevueltos["nombre"].ToString(),
                                         datosDevueltos["apellido"].ToString(),
                                         double.Parse(datosDevueltos["dni"].ToString())));
           
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
                ClienteBD.conexion.Close();
            }
            return todoOk;
        }
    }
}
