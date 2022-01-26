using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        /// <summary>
        /// Construcion por defecto.
        /// </summary>
        private Persona()
        {
            this.nombre = "Sin Nombre";
            this.apellido = "Sin Apellido";
        }

        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="nombre_Persona"></param>
        /// <param name="apellido_Persona"></param>
        public Persona(string nombre_Persona, string apellido_Persona):this()
        {
            this.nombre = nombre_Persona;
            this.apellido = apellido_Persona;
        }
        /// <summary>
        /// Getter de atributo nombre.
        /// </summary>
        public string Nombre 
        {
            get { return this.nombre; }
        }
        /// <summary>
        /// Getter de atributo apellido
        /// </summary>
        public string Apellido
        {
            get{ return apellido; }
        }
      
        public abstract string Ingresado();

    }
}
