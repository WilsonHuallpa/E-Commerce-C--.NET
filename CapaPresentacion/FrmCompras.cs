using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using CapaDatos;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {



        venta miventa;
        List<CarritodeCompras> listaCompras;
        string directorio = Directory.GetCurrentDirectory();
        double auxMontoTotal;
        SoundPlayer auxSonido;

        public venta Miventa { get => miventa; }


        public FrmCompras()
        {
            InitializeComponent();
            listaCompras = new List<CarritodeCompras>();
            auxSonido = new SoundPlayer();
            miventa = new venta();
            auxMontoTotal = 0;
        }



        private void FrmVenta_Load(object sender, EventArgs e)
        {
            auxSonido.SoundLocation = String.Concat(directorio, "/sonido.wav");
            this.cmbCliente.DataSource = Comercio.GetListaClientes();
            this.cmbCliente.DisplayMember = "Apellido";
            this.cmbEmpleado.DataSource = Comercio.GetListaEmpleados();
            this.cmbEmpleado.DisplayMember = "Nombre";

            CargaDatagrid();

        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente nuevoCliente = new FrmAgregarCliente();

            if (nuevoCliente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente. ", Comercio.NombreComercio);
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            double precio;
            string descripcion;
            int idProducto;
            int cantidad;

            if(int.TryParse(this.txtCantidad.Text, out cantidad))
            {
                descripcion = (string)dtgvCatalogo.CurrentRow.Cells["Descripcion"].Value;
                precio = (double)dtgvCatalogo.CurrentRow.Cells["Precio"].Value;
                idProducto = (int)dtgvCatalogo.CurrentRow.Cells["Codigo"].Value;

                if (!Validaciones.CerosYnegativos(cantidad))
                {
                    if (Comercio.ValidarCantidad(idProducto, cantidad))
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            listaCompras.Add(new CarritodeCompras(descripcion, precio, idProducto));
                        }
                        ReducirStock(idProducto,cantidad);

                        //actualizo el monto total, los datagridviews y el monto atraves del label.

                        auxMontoTotal += (precio * cantidad);
                        calcularCosto();
                        CargaDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock del producto solicitado", Comercio.NombreComercio);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad no puede ser 0 ni un numero negativo", Comercio.NombreComercio);
                }

            }else
            {
                MessageBox.Show("Por Favor, ingrese cantidad para continuar", Comercio.NombreComercio);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listaCompras.Count; i++)
            {
                for (int j = 0; j < Comercio.ListaProductos.Count; j++)
                {
                    if (listaCompras[i].IdCompra == Comercio.ListaProductos[j].Codigo)
                    {
                        Comercio.ListaProductos[j].Stock++;
                        break;
                    }
                }
            }

            listaCompras.Clear();
            CargaDatagrid();
            this.lbSubtotal.Text = "00,00";
            this.lbDescuento.Text = "00,00";
            this.lbPrecioTotal.Text = "00,00";

        }
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (listaCompras.Count > 0)
            {
                miventa = new venta((Empleado)this.cmbEmpleado.SelectedItem, (Cliente)this.cmbCliente.SelectedItem, listaCompras, auxMontoTotal);
                auxSonido.Play();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se registro ningun producto", Comercio.NombreComercio, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region metodos
        /// <summary>
        /// Recorre la lista de producto cuando la encuentra, reduce el stock
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="cantidad"></param>
        private void ReducirStock(int idProducto, int cantidad)
        {
            for (int i = 0; i < Comercio.ListaProductos.Count; i++)
            {
                if (idProducto == Comercio.ListaProductos[i].Codigo)
                {
                    Comercio.ListaProductos[i].Stock -= cantidad;
                }
            }
        }

        /// <summary>
        /// Carga datagrid
        /// </summary>
        private void CargaDatagrid()
        {
            this.dtgvCatalogo.DataSource = null;
            this.dtgvCatalogo.DataSource = Comercio.ListaProductos;
            this.dtgvSelecciona.DataSource = null;
            this.dtgvSelecciona.DataSource = this.listaCompras;
        }


        /// <summary>
        /// calcula el costo por tipo de cliente.
        /// </summary>
        private void calcularCosto()
        {
            Cliente micliente = (Cliente)this.cmbCliente.SelectedItem;

            if (Comercio.DescuentoASimpson(micliente))
            {
                double descuento = (auxMontoTotal) * 13 / 100;
                double sudtotal = auxMontoTotal;
                auxMontoTotal = sudtotal - descuento;
                this.lbDescuento.Text = descuento.ToString("N");
                this.lbSubtotal.Text = sudtotal.ToString("N");
                this.lbPrecioTotal.Text = auxMontoTotal.ToString("N");
            }
            else
            {
                this.lbDescuento.Text = "00,00";
                this.lbSubtotal.Text = auxMontoTotal.ToString("N");
                this.lbPrecioTotal.Text = auxMontoTotal.ToString("N");
            }
        }
        #endregion

    }
}
