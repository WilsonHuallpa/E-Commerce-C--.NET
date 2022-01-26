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
    public partial class FrmLogin : Form
    {
        string auxUser;
        int contador = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getter del usuario logueado
        /// </summary>
        public string AuxUser
        {
            get { return auxUser; }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            bool validarUsuario = false;

            if (!Validaciones.ValidarString(this.txtUsuario.Text) && !Validaciones.ValidarString(this.txtContraseña.Text))
            {
                contador++;
                foreach (var item in Comercio.ListaUsuario)
                {
                    if (item.Key == this.txtUsuario.Text)
                    {
                        if (item.Value == this.txtContraseña.Text)
                        {
                            validarUsuario = true;

                            auxUser = item.Key;

                            DialogResult = DialogResult.Yes;
                        }
                    }
                }
            }
            if (!validarUsuario)
            {
                MessageBox.Show("Verifique clave o contraseña", Comercio.NombreComercio);
            }
            if (contador == 3)
            {
                MessageBox.Show("Ha alcanzado el limite maximo de ingresos erroneos", Comercio.NombreComercio);
                this.Close();
            }

            this.txtUsuario.Clear();
            this.txtContraseña.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

        }

       
    }
}
