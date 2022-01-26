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
    public partial class FrmAgregarCliente : Form
    {
        Cliente auxCliente;
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDatos();

                auxCliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text, Convert.ToDouble(this.txtDni.Text));

                verificarYagregar(auxCliente);
              
            }
            catch(Exception errorDeDatos)
            {
                MessageBox.Show(errorDeDatos.Message);

                Limpiar();
            }
     
        }


        private void txtNombre_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = String.Concat(Char.ToUpper(((TextBox)sender).Text[0]), ((TextBox)sender).Text.Substring(1));

                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {
                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(((TextBox)sender).Text.Substring(0, posicion + 1),
                    Char.ToUpper(((TextBox)sender).Text[posicion + 1]), ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }
            }

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region metodos
        /// <summary>
        /// verifica si el cliente existe en mi lista de cliente.  si no existe lo agrega.
        /// </summary>
        /// <param name="auxcliente"></param>
        private void verificarYagregar(Cliente auxcliente)
        {
            if (Comercio.GetListaClientes() + auxcliente)
            {
                MessageBox.Show(auxCliente.Ingresado(), Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Cliente registrados previamentes, los datos no seran duplicados!", Comercio.NombreComercio);
            }
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// valida los datos de entrada.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        private void ValidarDatos()
        {
            double dni;

            if (double.TryParse(this.txtDni.Text, out dni) &&
                !Validaciones.ValidarString(this.txtNombre.Text) &&
                !Validaciones.ValidarString(this.txtApellido.Text))
            {
                if (Validaciones.CerosYnegativos(dni))
                {
                    throw new ErrordeDatosException("Verificar DNI");
                }
            }
            else
            {
                throw new ErrordeDatosException("Uno de los campos no es valido.");
            }
        }

 
        /// <summary>
        /// Limpia los campos. 
        /// </summary>
        private void Limpiar()
        {
            txtApellido.Clear();
            txtDni.Clear();
            txtNombre.Clear();
        }

        #endregion
    }
}
