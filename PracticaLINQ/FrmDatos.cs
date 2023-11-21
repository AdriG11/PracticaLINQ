using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLINQ
{
    public partial class FrmDatos : Form
    {
        List<ClsLista> MiLista = new List<ClsLista>();
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            if (ValidarRaza() == false)
            {
                return;
            }
            if (validarEdad() == false)
            {
                return;
            }
            ClsLista miMascota = new ClsLista();
            miMascota.Nombre = txtNombre.Text;
            miMascota.Raza = cmbRaza.SelectedItem.ToString();
            miMascota.Edad = int.Parse(txtEdad.Text);
            MiLista.Add(miMascota);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            LimpiarControles();
            txtNombre.Focus();

        }

        private bool validarEdad()
        {
            int Edad;
            if (int.TryParse(txtEdad.Text, out Edad) || txtEdad.Text == " ")
            {
                erpError.SetError(txtEdad, "Debe ingresar un valor numerico para la edad");
                txtEdad.Clear();
                txtEdad.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtEdad, " ");
                return true;
            }

        }

        //Validar Raza
        private bool ValidarRaza()
        {
            if (string.IsNullOrEmpty(cmbRaza.Text))
            {
                erpError.SetError(cmbRaza, "Debe seleccionar una Raza");
                return false;
            }
            else
            {
                erpError.SetError(cmbRaza, " ");
                return true;
            }
        }

        //Validarel nombre
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe de ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                {
                    return true;
                }
            }
        }
        //Crear metodo para limpiar los controles

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            cmbRaza.SelectedIndex = 0;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
