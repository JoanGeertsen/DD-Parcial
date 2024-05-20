﻿using System;
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
        #region Atributos
        private Coleccion _Coleccion;
        #endregion
        public FCarga(Coleccion _Coleccion)
        {
            InitializeComponent();
            this._Coleccion = _Coleccion; 
        }

        #region Funcionalidades
        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbTipoProducto.SelectedIndex;
            if (selectedIndex == 0 || selectedIndex == 1) { pTe.Visible = false; pInfusion.Visible = false; pCafe.Visible = true; }
            else if (selectedIndex == 2) { pTe.Visible = true; pInfusion.Visible = false; pCafe.Visible = false; }
            else if (selectedIndex == 3) { pInfusion.Visible = true; pTe.Visible = false; pCafe.Visible = false; }
        }

        private bool todoValidado()
        {
            bool validado = false;
            int selectedIndex = cbTipoProducto.SelectedIndex;
            ep.Clear();

            //Recorre todos los controles que hay que verificar, para asegurar que tenga un error en caso de necesitarlo.
            cbTipoProducto.Focus(); tNombre.Focus(); tPrecio.Focus();
            if (selectedIndex == 0 || selectedIndex == 1) { cbTueste.Focus(); tOrigen.Focus(); }
            else if (selectedIndex == 2) { cbTipoTe.Focus(); }
            else if (selectedIndex == 3) { rtDescripcion.Focus(); }
            cbTipoProducto.Focus();

            if ((selectedIndex == 0 || selectedIndex == 1) && string.IsNullOrEmpty(ep.GetError(cbTueste)) && string.IsNullOrEmpty(ep.GetError(tOrigen)))
                validado = true;
            else if (selectedIndex == 2 && string.IsNullOrEmpty(ep.GetError(cbTipoTe)))
                validado = true;
            else if (selectedIndex == 3 && string.IsNullOrEmpty(ep.GetError(rtDescripcion)))
                validado = true;

            if (!string.IsNullOrEmpty(ep.GetError(cbTipoProducto)) && !string.IsNullOrEmpty(ep.GetError(tNombre)) && !string.IsNullOrEmpty(ep.GetError(tPrecio)))
                validado = false;


            return validado;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(todoValidado().ToString());
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
        private void cbTueste_Validating(object sender, CancelEventArgs e)
        {
            if (cbTueste.SelectedIndex == -1) ep.SetError(cbTueste, "Tueste no seleccionado");
            else ep.SetError(cbTueste, "");
        }

        private void tOrigen_Validating(object sender, CancelEventArgs e)
        {
            if (tOrigen.Text == "Origen") ep.SetError(tOrigen, "Origen inválido");
            else ep.SetError(tOrigen, "");
        }

        private void cbTipoTe_Validating(object sender, CancelEventArgs e)
        {
            if (cbTipoTe.SelectedIndex == -1) ep.SetError(cbTipoTe, "Tipo no seleccionado");
            else ep.SetError(cbTipoTe, "");
        }

        private void rtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (rtDescripcion.Text == "Descripción...") ep.SetError(rtDescripcion, "Descripción inválida");
            else ep.SetError(rtDescripcion, "");
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
