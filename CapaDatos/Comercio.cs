using CapaDatos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Comercio
    {
        static List<Producto> listaProductos;
        static List<Persona> listaPersonas;
        static List<venta> listaventas;
        static Dictionary<string, string> listaUsuario;
        static Empleado empleadoLogueado;
        static string nombreComercio;

        #region Constructores
        /// <summary>
        /// constructor por defecto.
        /// </summary>
        static Comercio() {

            nombreComercio = "Kwik E Mart";
            listaProductos = new List<Producto>();
            listaPersonas = new List<Persona>();
            listaventas = new List<venta>();
            listaUsuario = new Dictionary<string, string>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad get listaventas.
        /// </summary>
        public static List<venta> Listaventas { get => listaventas; }

        /// <summary>
        /// Propiedad get de nombreComercio.
        /// </summary>
        public static string NombreComercio { get => nombreComercio; }

        /// <summary>
        /// Propiedad de get de listaProduco.
        /// </summary>
        public static List<Producto> ListaProductos { get => listaProductos; }

        /// <summary>
        /// Getter del empleado logueado
        /// </summary>
        public static Empleado EmpleadoLogueado { get => empleadoLogueado; }

        /// <summary>
        /// Getter del Dictionary con los usuarios y sus claves.
        /// </summary>
        public static Dictionary<string, string> ListaUsuario { get => listaUsuario;}

        /// <summary>
        /// Getter de lista de personas
        /// </summary>
        public static List<Persona> ListaPersonas { get => listaPersonas; }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo calcular el stock de Producto.
        /// </summary>
        /// <returns>la cantidad total de productos en el comercio.</returns>
        public static int StockDeProducto()
        {
            int acumulador = 0;

            for (int i = 0; i < ListaProductos.Count; i++)
            {
                acumulador += ListaProductos[i].Stock;
            }

            return acumulador;
        }



        /// <summary>
        /// Metodo que crea una sublista solo con la idEmpleado.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns>retorno la una sublista.</returns>
        public static List<venta> GetListaVentas(int idEmpleado)
        {
            List<venta> auxListaventas = new List<venta>();

            foreach (venta v in listaventas)
            {
                if (v.id == idEmpleado)
                {
                    auxListaventas.Add(v);
                }
            }
            return auxListaventas;
        }

       
        /// <summary>
        /// crea una sublista con los producto de menor de 10 cantidad.
        /// </summary>
        /// <returns>Retorno una sublista de Producto</returns>
        public static List<Producto> StockMenorde10()
        {
            List<Producto> auxproductos = new List<Producto>();

            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if(ListaProductos[i].Stock < 10)

                    auxproductos.Add(ListaProductos[i]);
            }

            return auxproductos;
        }

        /// <summary>
        /// validar si el cliente es un miembro de la familia simpson
        /// </summary>
        /// <param name="auxClient"> cliente a validar.</param>
        /// <returns>true si es simpson, false si no lo es.</returns>
        public static bool DescuentoASimpson (Cliente auxClient)
        {
            if(auxClient.Apellido == "Simpson")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida si el valor de stock solicitado es menor al disponible.
        /// </summary>
        /// <param name="idProducto"> id del producto.</param>
        /// <param name="auxCantidad">Cantidad sugerida</param>
        /// <returns>true si auxcantidad es menor o igual al stock de producto.</returns>
        public static bool ValidarCantidad(int idProducto, int auxCantidad)
        {
            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if(ListaProductos[i].Codigo == idProducto && ListaProductos[i].Stock >= auxCantidad)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Hace una carga instantanea de 5 clientes
        /// </summary>
        public static void HarcodeoCliente()
        {
            List<Cliente> listaClientes = ClienteBD.Leer();

            foreach (Cliente auxCliente in listaClientes)
            {
                listaPersonas.Add(auxCliente);
            }
        }

        /// <summary>
        /// Hardcodeo de usuarios para login de empleados
        /// </summary>
        public static void HardcodeoUsuarios()
        {
            listaUsuario.Add("huallpa", "123");
            listaUsuario.Add("porcel", "456");
            listaUsuario.Add("condori", "789");
        }
        /// <summary>
        /// Harcodeo de 3 empleados. 
        /// </summary>
        public static void HarcodeoEmpleado()
        {
            string[] nombre = new string[3] { "Wilson", "Ariel", "Nestor" };
            string[] apellido = new string[3] { "Huallpa", "Porcel", "Condori" };
            int[] id = new int[3] { 1, 2, 3 };
            string[] usuario = new string[3] { "huallpa", "porcel", "condori" };

            for (int i = 0; i < 3; i++)
            {
                listaPersonas.Add(new Empleado(nombre[i], apellido[i], id[i], usuario[i]));
            }
        }


        /// <summary>
        /// Obtiene la lista de Productos existente en la base de datos.
        /// </summary>
        /// 
        public static void GetProductosExitente()
        {
            listaProductos = ProductosBD.Leer();
        }

        /// <summary>
        /// Hace una carga instantanea de 5 productos perecederos
        /// </summary>
        /// 
        public static void HardcodeoCompras()
        {
            Empleado[] auxEmpleado = new Empleado[50] {new Empleado("Wilson", "Huallpa",1, "huallpa"), new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),new Empleado("Wilson", "Huallpa",1, "huallpa"),
            new Empleado("Ariel", "Porcel",2, "porcel"), new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),new Empleado("Ariel", "Porcel",2, "porcel"),
            new Empleado("Nestor", "Condori", 3, "condori"),new Empleado("Nestor", "Condori", 3, "condori"),new Empleado("Nestor", "Condori", 3, "condori"),
            new Empleado("Nestor", "Condori", 3, "condori"),new Empleado("Nestor", "Condori", 3, "condori"),new Empleado("Nestor", "Condori", 3, "condori"),
            new Empleado("Nestor", "Condori", 3, "condori"),new Empleado("Nestor", "Condori", 3, "condori"),new Empleado("Nestor", "Condori", 3, "condori")};

            Cliente[] auxCliente = new Cliente[50] {new Cliente("Ned","Flanders",333333), new Cliente("Ned","Flanders",333333),
            new Cliente("Ned","Flanders",333333),new Cliente("Homero","Simpson",123456),new Cliente("Ned","Flanders",333333),
            new Cliente("Homero","Simpson",123456),new Cliente("Ned","Flanders",333333),new Cliente("Homero","Simpson",123456),
            new Cliente("Homero","Simpson",123456), new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),
            new Cliente("Homero","Simpson",123456),new Cliente("Ned","Flanders",333333),new Cliente("Ned","Flanders",333333),
            new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),
            new Cliente("Ned","Flanders",333333),new Cliente("Ned","Flanders",333333), new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),
            new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Montgomery","Burns",2222222), new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),
            new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),
            new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),
            new Cliente("Montgomery","Burns",2222222), new Cliente("Montgomery","Burns",2222222)};

            string[] descripcion = new string[50] { "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te", "Arroz", "Jabon en polvo", "Mate cocido", "Salsa de tomate",
            "Arvejas", "Choclo", "Atun", "Jugo de naranja", "Jugo de manzana", "Caldo",  "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te" };

            double[] precio = new double[50] { 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51, 63, 177, 48, 55, 68, 88, 91, 145, 141, 30, 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51 };

            int[] idProducto = new int[50] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23, 24, 25, 26, 27, 28, 29, 30, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < 50; i++)
            {
                List<CarritodeCompras> auxLista = new List<CarritodeCompras>();
                auxLista.Add(new CarritodeCompras(descripcion[i], precio[i], idProducto[i]));
                auxLista.Add(new CarritodeCompras(descripcion[i], precio[i], idProducto[i]));
                auxLista.Add(new CarritodeCompras(descripcion[i], precio[i], idProducto[i]));
                listaventas.Add(new venta(auxEmpleado[i], auxCliente[i], auxLista, (precio[i] * 3)));
            }
        }


        ///// <summary>
        ///// Verifica si en una lista de tipo Persona existen objetos de tipo Empleado y crea una sublista
        ///// </summary>
        ///// <returns>List<> de tipo Empleado</returns>
        public static List<Empleado> GetListaEmpleados()
        {
            List<Empleado> auxListaEmpleados = new List<Empleado>();

            foreach (Persona item in listaPersonas)
            {
                if (item is Empleado)
                {
                    auxListaEmpleados.Add((Empleado)item);
                }
            }

            return auxListaEmpleados;
        }

        /// <summary>
        /// Verifica si en una lista de tipo Persona existen objetos de tipo Cliente y crea una sublista
        /// </summary>
        /// <returns>List<> de tipo Cliente</returns>
        public static List<Cliente> GetListaClientes()
        {
            List<Cliente> auxListaClientes = new List<Cliente>();

            foreach (Persona item in listaPersonas)
            {
                if (item is Cliente)
                {
                    auxListaClientes.Add((Cliente)item);
                }
            }

            return auxListaClientes;
        }

        /// <summary>
        /// Crea un objeto de tipo Empleado referente al empleado logueado
        /// </summary>
        /// <param name="usuarioActivo"></param>
        public static void AuxEmpleadoLogueado(string usuarioActivo)
        {
            List<Empleado> auxListaEmpleados;

            auxListaEmpleados = GetListaEmpleados();

            for (int i = 0; i < auxListaEmpleados.Count; i++)
            {
                if (auxListaEmpleados[i].Usuario == usuarioActivo)
                {
                    empleadoLogueado = auxListaEmpleados[i];
                    break;
                }
            }
        }
        #endregion
    }
}
