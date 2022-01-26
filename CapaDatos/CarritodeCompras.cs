using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CarritodeCompras
    {
        string descripcion;
        double precio;
        int idCompra;

        #region Constructores
        /// <summary>
        /// Constructur por defecto
        /// </summary>
        public CarritodeCompras()
        {
            this.descripcion = "Sin decripcion";
            this.precio = -1;
            this.idCompra = -1;
        }

        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="decripcion"></param>
        /// <param name="precio"></param>
        /// <param name="idCompra"></param>
        public CarritodeCompras(string decripcion, double precio, int idCompra) : this()
        {
            this.descripcion = decripcion;
            this.precio = precio;
            this.idCompra = idCompra;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Propidad de GEt id compra
        /// </summary>
        public int IdCompra
        {
            get { return this.idCompra; }
        }
        /// <summary>
        /// Propiedad de Get Desgreciones 
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        /// <summary>
        /// Propiedad get del precio.
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }
        #endregion


    }
}
