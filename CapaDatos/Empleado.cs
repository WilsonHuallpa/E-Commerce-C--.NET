using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado : Persona
    {
        int idEmpleado;
        string usuario;
        #region Constructor
        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="telefono"></param>
        /// <param name="id"></param>
        /// <param name="usuario"></param>
        public Empleado(string nombre, string apellido, int id, string usuario) : base( nombre, apellido)
        {
            this.idEmpleado = id;
            this.usuario = usuario;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Get de id empleado.
        /// </summary>
        public int IdEmpleado
        {
            get { return this.idEmpleado; }
        }
        /// <summary>
        /// Propiedad Get de usuario del empleado.
        /// </summary>
        public string Usuario
        {
            get { return this.usuario; }
        }
        #endregion

        public override string Ingresado()
        {
            return $"Se ha registrado el Empleado Nombre: {this.nombre} , apellido: {this.apellido}";
        }

    }
}
