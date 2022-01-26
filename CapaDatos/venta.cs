using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class venta
    {
        Empleado vendedor;
        Cliente comprador;
        List<CarritodeCompras> listaComprar;
        double montoTotal;
        static int numeroFactura = 100;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
       public venta()
        {
            listaComprar = new List<CarritodeCompras>();
            numeroFactura = 1 + numeroFactura;
        }
        /// <summary>
        /// Constructor por parametros. 
        /// </summary>
        /// <param name="vendedor"></param>
        /// <param name="comprador"></param>
        /// <param name="listaCompra"></param>
        /// <param name="montoTotal"></param>
        public venta(Empleado vendedor, Cliente comprador, List<CarritodeCompras> listaCompra, double montoTotal): this()
        {
            this.vendedor = vendedor;
            this.comprador = comprador;
            this.listaComprar = listaCompra;
            this.montoTotal = montoTotal;

        }
        /// <summary>
        /// Propiedad Getter del campo apellido.
        /// </summary>
        public string ApellidoVendedor
        {
            get { return vendedor.Apellido; }
        }
        /// <summary>
        /// Propiedad Getter del campo Id empleado.
        /// </summary>
        public int id
        {
            get { return vendedor.IdEmpleado; }
        }
        /// <summary>
        /// Propiedad Getter del campo apellido.
        /// </summary>
        public string ApellidoCliente
        {
            get { return comprador.Apellido; }
        }
        /// <summary>
        /// Propiedad Getter del campo nombre cliente.
        /// </summary>
        public string NombreCliente
        {
            get { return comprador.Nombre; }
        }
        /// <summary>
        /// Propiedad Getter del campo lista comprar cantidad.
        /// </summary>
        public int CantArt
        {
            get { return listaComprar.Count; }
        }
        /// <summary>
        /// Propiedad Getter del campo monto total.
        /// </summary>
        public double Total
        {
            get { return montoTotal; }
        }
    }
}
