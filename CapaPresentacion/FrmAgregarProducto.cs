using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAgregarProducto : Form
    {

        Producto auxProducto;
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ChequearDatos();

                switch ((Producto.ETipo)this.cmbTIPO.SelectedValue)
                {
                    case Producto.ETipo.perecedero:
                        verificarYagregar();
                        break;
                    case Producto.ETipo.noPerecedero:
                        verificarYagregar();
                        break;
                    case Producto.ETipo.almacen:
                        verificarYagregar();
                        break;
                }

            }
            catch(Exception miErrorDatos)
            {
                MessageBox.Show(miErrorDatos.Message,Comercio.NombreComercio);
            }

        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            this.cmbTIPO.DataSource = Enum.GetValues(typeof(Producto.ETipo));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }



        /// <summary>
        /// Convierte la primera letra en mayuscula y el resto en minusculas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            this.txtdecripcion.Text = this.txtdecripcion.Text.Trim();
            this.txtdecripcion.Text = this.txtdecripcion.Text.ToLower();
            if (this.txtdecripcion.Text.Length > 2)
            {
                this.txtdecripcion.Text = String.Concat(Char.ToUpper(this.txtdecripcion.Text[0]), this.txtdecripcion.Text.Substring(1));
            }
        }

        #region metodos
        /// <summary>
        /// chequea si los datos ingresado son correctos, si no lanza una excepcion.
        /// </summary>
        private void ChequearDatos()
        {
            double precio;
            int stock;
            int id;
            this.txtPrecio.Text = this.txtPrecio.Text.Replace(".", ",");

            if (double.TryParse(this.txtPrecio.Text, out precio) && int.TryParse(this.txtCantidad.Text, out stock)
             && !Validaciones.ValidarString(this.txtdecripcion.Text) && int.TryParse(this.txtcodigo.Text, out id))
            {
                if (Validaciones.CerosYnegativos(precio) || Validaciones.CerosYnegativos(stock) || Validaciones.CerosYnegativos(id))
                {
                    throw new ErrordeDatosException("Verificar campo numericos");
                }
                if (this.cmbTIPO.SelectedIndex == -1)
                {
                    throw new ErrordeDatosException("Verificar El ComboBox, debe elegir un tipo");
                }
            }
            else
            {
                throw new ErrordeDatosException("Verificar datos ingresados");
            }

        }

        /// <summary>
        /// verifica si el producto ya existe, si no lo agrega correctamente. 
        /// </summary>
        private void verificarYagregar()
        {
            auxProducto = new ProductoPerecedero(this.txtdecripcion.Text, Convert.ToInt32(this.txtcodigo.Text), Convert.ToDouble(this.txtPrecio.Text), Convert.ToInt32(this.txtCantidad.Text), (Producto.ETipo)this.cmbTIPO.SelectedValue);

            if (Comercio.ListaProductos + auxProducto)
            {
                MessageBox.Show("Producto cargado con exitos", Comercio.NombreComercio);
                MessageBox.Show(auxProducto.Mostrar(), Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Producto previamente cargados", Comercio.NombreComercio);
                MessageBox.Show("Solo se modifico el stock disponibles", Comercio.NombreComercio);
            }
            this.Limpiar();
        }

        /// <summary>
        /// limpiar
        /// </summary>
        private void Limpiar()
        {
            this.txtcodigo.Clear();
            this.txtCantidad.Clear();
            this.txtPrecio.Clear();
            this.txtdecripcion.Clear();
        }
        #endregion
    }
}
