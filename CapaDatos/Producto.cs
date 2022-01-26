using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    #pragma warning disable CS0660  
    #pragma warning disable CS0661 
    public abstract class Producto
    {

        protected int codigo;
        protected double precio;
        protected string descripcion;
        protected int stock;
        protected ETipo tipoProducto;
        public enum ETipo
        {
            perecedero,
            noPerecedero,
            almacen
        }

        #region Constructor
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Producto()
        {
            this.descripcion = "sin descripcion";
            this.codigo = -1;
            this.precio = -1;
            this.stock = -1;
        }

        /// <summary>
        /// Constructor de objetos de tipo Producto
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipoProducto"></param>
        public Producto(string descripcion, int idProducto, double precio, int stock, ETipo tipoProducto) : this()
        {
            this.descripcion = descripcion;
            this.codigo = idProducto;
            this.precio = precio;
            this.stock = stock;
            this.tipoProducto = tipoProducto;
        }
        #endregion

        #region Propiedades
        /// <summary>
        ///  Propiedad Getter del campo codigo de barra.
        /// </summary>
        public int Codigo
        {
            get { return this.codigo; }
        }
       
        /// <summary>
        ///  Propiedad Getter del campo Precio.
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }

        /// <summary>
        ///  Propiedad Getter del campo descripcion.
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
        }
       
        public int Stock
        {
            get { return this.stock; }

            set
            {
                this.stock = value;

                if(this.stock < 0)
                {
                    this.stock = 0;
                }

            }
        }
        #endregion
        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga operador ==
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="auxProducto"></param>
        /// <returns></returns>
        public static bool operator ==(List<Producto> listaProductos, Producto auxProducto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].codigo == auxProducto.codigo)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga operador !=
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="auxProducto"></param>
        /// <returns></returns>
        public static bool operator !=(List<Producto> listaProductos, Producto auxProducto)
        {
            return !(listaProductos == auxProducto);
        }

        /// <summary>
        /// Sobrecarga operador +
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="auxProducto"></param>
        /// <returns></returns>
        public static bool operator +(List<Producto> listaProductos, Producto auxProducto)
        {
            bool retorno = false;

            if (listaProductos != auxProducto)
            {
                listaProductos.Add(auxProducto);
                retorno = true;
            }
            else
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].codigo == auxProducto.codigo)
                    {
                        listaProductos[i].Stock = auxProducto.Stock;
                    }
                }
            }

            return retorno;
        }
        #endregion

        /// <summary>
        /// Genera un stringbuilder con todos los datos del producto
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Descripcion: {this.descripcion}");
            sb.AppendLine($"Stock: {this.stock.ToString()}");
            sb.AppendLine($"ID Producto: {this.codigo.ToString()}");
            sb.AppendLine(String.Format("Precio: ${0: #,###.00}", this.precio));

            return sb.ToString();
        }
       
    }
}
