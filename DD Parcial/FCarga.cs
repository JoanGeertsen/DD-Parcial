using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DD_Parcial
{
    public partial class FCarga : Form
    {
        public FCarga()
        {
            InitializeComponent();
        }

        #region Funcionalidades
        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbTipoProducto.SelectedIndex;
            if (selectedIndex == 0 || selectedIndex == 1) { pTe.Visible = false; pInfusion.Visible = false; pCafe.Visible = true; }
            else if (selectedIndex == 2) { pTe.Visible = true; pInfusion.Visible = false; pCafe.Visible = false; }
            else if (selectedIndex == 3) { pInfusion.Visible = true; pTe.Visible = false; pCafe.Visible = false; }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Validaciones de campo
        private void cbTipoProducto_Validating(object sender, CancelEventArgs e)
        {
            if (cbTipoProducto.SelectedIndex == -1) ep.SetError(cbTipoProducto, "Producto no seleccionado");
            else ep.SetError(cbTipoProducto, "");
        }

        private void tNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tNombre.Text == "Nombre") ep.SetError(tNombre, "Nombre inválido");
            else ep.SetError(tNombre, "");
        }

        private void tPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (tPrecio.Text == null || tPrecio.Text.Trim() == "") tPrecio.Text = "0";
            if (double.Parse(tPrecio.Text) <= 0) ep.SetError(tPrecio, "Precio invalido");
            else ep.SetError(tPrecio, "");
        }
        private void dtFechaVencimiento_Validating(object sender, CancelEventArgs e)
        {
            if (dtFechaVencimiento.Value < DateTime.Today) ep.SetError(dtFechaVencimiento, "Producto vencido");
            else ep.SetError(dtFechaVencimiento, "");
        }
        #endregion

        #region Marcas de agua
        private void tNombre_Enter(object sender, EventArgs e)
        {
            if (tNombre.Text == "Nombre")
            {
                tNombre.Text = "";
                tNombre.ForeColor = Color.Black;
            }
        }

        private void tNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tNombre.Text))
            {
                tNombre.Text = "Nombre";
                tNombre.ForeColor = Color.Gray;
            }
        }

        private void rtDescripcion_Enter(object sender, EventArgs e)
        {
            if (rtDescripcion.Text == "Descripción...")
            {
                rtDescripcion.Text = "";
                rtDescripcion.ForeColor = Color.Black;
            }
        }

        private void rtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtDescripcion.Text))
            {
                rtDescripcion.Text = "Descripción...";
                rtDescripcion.ForeColor = Color.Gray;
            }
        }

        private void tOrigen_Enter(object sender, EventArgs e)
        {
            if (tOrigen.Text == "Origen")
            {
                tOrigen.Text = "";
                tOrigen.ForeColor = Color.Black;
            }
        }

        private void tOrigen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tOrigen.Text))
            {
                tOrigen.Text = "Origen";
                tOrigen.ForeColor = Color.Gray;
            }
        }
        private void tPrecio_Enter(object sender, EventArgs e)
        {
            if (tPrecio.Text == "0")
            {
                tPrecio.Text = "";
                tPrecio.ForeColor = Color.Black;
            }
        }

        private void tPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tPrecio.Text))
            {
                tPrecio.Text = "0";
                tPrecio.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region KeyPress
        private void tPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                         
                e.Handled = true;            
        }
        #endregion
    }
}
