using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGuiadaEjFinal
{
    public partial class fdmInicio : Form
    {
        public fdmInicio()
        {
            //asd
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 ||  e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = Color.White;
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = Color.White;
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = Color.White; if (txtNombre.Text == "")
                txtEdad.BackColor = Color.Red;
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = Color.White;
            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text.ToString() + " " + txtNombre.Text.ToString() + "\r\nEdad: " + txtEdad.Text.ToString() + "\r\nDirección: " + txtDireccion.Text.ToString();
        }
    }
}
