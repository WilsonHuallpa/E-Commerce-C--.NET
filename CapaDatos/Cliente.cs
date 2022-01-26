using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    #pragma warning disable CS0660 
    #pragma warning disable CS0661  
    public class Cliente : Persona
    {
        #region Constructor
        double dni;
        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido,double dni): base(nombre,apellido)
        {
            this.dni = dni;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Getter de atributo DNI
        /// </summary>
        public double Dni
        {
            get { return this.dni; }
        }
        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Operardor == entre un lista de cliente y un cliente
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="auxCliente"></param>
        /// <returns>true si el cliente exite en la lista. </returns>
        public static bool operator == (List<Cliente> listaClientes, Cliente auxCliente)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if(listaClientes[i].dni == auxCliente.dni)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Sobrecarga de operador !=
        /// </summary>
        /// <param name="listaCliente"></param>
        /// <param name="auxCliente"></param>
        /// <returns>true si son distintos, flase si son iguales.</returns>
        public static bool operator != (List<Cliente> listaCliente, Cliente auxCliente)
        {
            return !(listaCliente == auxCliente);
        }


        /// <summary>
        /// agrega un cliente a la lista en caso de no existir en la misma
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>bool</returns>
        public static bool operator +(List<Cliente> clientes, Cliente cliente)
        {
            if (clientes != cliente)
            {
                clientes.Add(cliente);
                return true;
            }

            return false;
        }

        #endregion

        public override string Ingresado()
        {
            return $"Se ha registrado el cliente Nombre: {this.nombre} , apellido: {this.apellido}";
        }


    }
}
