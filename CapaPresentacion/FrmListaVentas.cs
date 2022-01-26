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
    public partial class FrmListaVentas : Form
    {

        List<venta> auxListaVentas;
        public FrmListaVentas()
        {
            InitializeComponent();
        }

        private void FrmListaCompras_Load(object sender, EventArgs e)
        {
            this.dgvEmpleado.DataSource = Comercio.GetListaEmpleados();
        }


        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEmpleado = (int)this.dgvEmpleado.CurrentRow.Cells["IdEmpleado"].Value;
            string nombre = (string)this.dgvEmpleado.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)this.dgvEmpleado.CurrentRow.Cells["Apellido"].Value;

            auxListaVentas = Comercio.GetListaVentas(idEmpleado);

            this.lbListaEmpleado.Text = String.Concat("Empleado: ", nombre, ", ", apellido);
            this.CargarDatagrid();
        }

        private void CargarDatagrid()
        {
            this.dgvEmpleado.DataSource = null;
            this.dgvEmpleado.DataSource = auxListaVentas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.dgvEmpleado.DataSource = Comercio.GetListaEmpleados();
        }
    }
}
