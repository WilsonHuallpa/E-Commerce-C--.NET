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
    public partial class FrmPrincipal : Form
    {
        public static DateTime? _lostFocusTime;
        int _counter = 0;
        bool login = false;
        SoundPlayer auxSonido;
        string directorio = Directory.GetCurrentDirectory();
        public FrmPrincipal()
        {
            InitializeComponent();
            auxSonido = new SoundPlayer();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            HarcodeoGeneral();
            auxSonido.SoundLocation = String.Concat(directorio,"/sonar.wav");

            FrmLogin auxLogin = new FrmLogin();

            if (auxLogin.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Login exitoso", Comercio.NombreComercio);
                Comercio.AuxEmpleadoLogueado(auxLogin.AuxUser);
                auxSonido.Play();
                login = true;
            }
            else
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin milogin = new FrmLogin();

            milogin.Show();
            this.Close();
        }

        private void opcionAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregarProducto = new FrmAgregarProducto();

            if (agregarProducto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmStockDeArticulo listaProducto = new FrmStockDeArticulo();

            if (listaProducto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras frmCompras = new FrmCompras();

            if (frmCompras.ShowDialog() == DialogResult.OK)
            {
                Comercio.Listaventas.Add(frmCompras.Miventa);

                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmListaVentas listaVentas = new FrmListaVentas();

            if (listaVentas.ShowDialog() == DialogResult.OK)
            {
                auxSonido.Play();
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente nuevoCliente = new FrmAgregarCliente();

            if (nuevoCliente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!! Vuelva Prontoss. ", Comercio.NombreComercio);
            }
        }

        private void HarcodeoGeneral()
        {
            Comercio.HarcodeoCliente();
            Comercio.HarcodeoEmpleado();
            //Comercio.HardcodeoProductosNoPerecederos();
            //Comercio.HardcodeoProductosPerecederos();
            //Comercio.HardcodeoProductosAlmacen();
            Comercio.GetProductosExitente();

            Comercio.HardcodeoUsuarios();
            Comercio.HardcodeoCompras();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
