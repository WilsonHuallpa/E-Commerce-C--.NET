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
    public partial class FrmStockDeArticulo : Form
    {


        public FrmStockDeArticulo()
        {
            InitializeComponent();
        }


        private void btnListaProducto_Click(object sender, EventArgs e)
        {
            CargaDatagrid();
            this.lblStockTotal.Text = Comercio.StockDeProducto().ToString();
        }

        private void CargaDatagrid()
        {
            this.dgvListaProducto.DataSource = null;
            this.dgvListaProducto.DataSource = Comercio.ListaProductos;
        }

        private void btnMenorde10_Click(object sender, EventArgs e)
        {
            this.dgvListaProducto.DataSource = null;
            this.dgvListaProducto.DataSource = Comercio.StockMenorde10();
        }

        private void lbVolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregarProducto = new FrmAgregarProducto();

            if (agregarProducto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
          
        }

        private void FrmStockDeArticulo_Load(object sender, EventArgs e)
        {
            this.lblStockTotal.Text = Comercio.StockDeProducto().ToString();

            CargaDatagrid();
        }

      
    }
}
