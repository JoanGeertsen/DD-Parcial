using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private FPrincipal _FormularioPrincipal;
        #endregion
        public FCarga(Coleccion _Coleccion, FPrincipal _FormularioPrincipal)
        {
            InitializeComponent();
            this._Coleccion = _Coleccion;
            this._FormularioPrincipal = _FormularioPrincipal;
        }

        #region Funcionalidades

        public void Mostrar(Producto producto)
        {
            colorTextBox(); cbTipoProducto.Enabled = false; tCodigo.Enabled = false; ep.Clear();
            //Campos de producto:
            tNombre.Text = producto.Nombre; tCodigo.Text = producto.Codigo.ToString(); dtFechaVencimiento.Value = producto.FechaVencimiento;
            tPrecio.Text = producto.Precio.ToString(); nudStock.Value = producto.Stock;

            if (producto is Cafe cafe)//Campos de café
            {
                if (producto is Filtro) cbTipoProducto.SelectedIndex = 0; else cbTipoProducto.SelectedIndex = 1;

                if (cafe.Tueste.ToLower() == "bajo") cbTueste.SelectedIndex = 0;
                else if (cafe.Tueste.ToLower() == "medio") cbTueste.SelectedIndex = 1;
                else if (cafe.Tueste.ToLower() == "alto") cbTueste.SelectedIndex = 2;

                tOrigen.Text = cafe.Origen;
                chMolido.Checked = cafe.Molido;
            }

            else if (producto is Te te)//Campos de té
            {
                cbTipoProducto.SelectedIndex = 2;

                string[] tiposDeTe = { "verde", "blanco", "amarillo", "oolong", "negro", "pu-erh" };
                int indice = Array.IndexOf(tiposDeTe, te.Tipo.ToLower());
                cbTipoTe.SelectedIndex = indice;
                chPresentacion.Checked = te.PresentacionEnLata;
            }

            else if (producto is Infusion infusion)//Campos de infusión
            {
                cbTipoProducto.SelectedIndex = 3;

                rtDescripcion.Text = infusion.Descripcion;
            }
        }
        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbTipoProducto.SelectedIndex;
            if (selectedIndex == 0 || selectedIndex == 1) { pTe.Visible = false; pInfusion.Visible = false; pCafe.Visible = true; }
            else if (selectedIndex == 2) { pTe.Visible = true; pInfusion.Visible = false; pCafe.Visible = false; }
            else if (selectedIndex == 3) { pInfusion.Visible = true; pTe.Visible = false; pCafe.Visible = false; }
        }

        private bool TodoValidado()
        {
            bool validado = false;
            int selectedIndex = cbTipoProducto.SelectedIndex;
            ep.Clear();

            //Recorre todos los controles que hay que verificar, para asegurar que tenga un error en caso de necesitarlo.
            cbTipoProducto.Focus(); tNombre.Focus(); tCodigo.Focus(); dtFechaVencimiento.Focus(); tPrecio.Focus();
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

            if (!string.IsNullOrEmpty(ep.GetError(cbTipoProducto)) || !string.IsNullOrEmpty(ep.GetError(tNombre)) || !string.IsNullOrEmpty(ep.GetError(tCodigo)) || !string.IsNullOrEmpty(ep.GetError(dtFechaVencimiento)) || !string.IsNullOrEmpty(ep.GetError(tPrecio)))
                validado = false;


            return validado;
        }

        private void ArmarProductoBase(Producto producto)
        {
            producto.Nombre = tNombre.Text;
            producto.Codigo = int.Parse(tCodigo.Text);
            producto.FechaVencimiento = dtFechaVencimiento.Value.Date;
            producto.Precio = double.Parse(tPrecio.Text);
            producto.Stock = (int)nudStock.Value;
        }

        private void ArmarCafe(Cafe cafe)
        {
            cafe.Tueste = cbTueste.Text;
            cafe.Origen = tOrigen.Text;
            cafe.Molido = chMolido.Checked;
        }

        private void ArmarTe(Te te)
        {
            te.Tipo = cbTipoTe.Text;
            te.PresentacionEnLata = chPresentacion.Checked;
        }

        private void ArmarInfusion(Infusion infusion)
        {
            infusion.Descripcion = rtDescripcion.Text;
        }

        private void LimpiarCampos()
        {
            tNombre.Clear(); tCodigo.Clear(); tPrecio.Clear(); nudStock.Value = 0;
            cbTueste.SelectedIndex = -1; tOrigen.Clear(); chMolido.Checked = false;
            cbTipoTe.SelectedIndex = -1; chPresentacion.Checked = false;
            rtDescripcion.Clear();

            TodoValidado(); ep.Clear(); cbTipoProducto.Enabled = true; tCodigo.Enabled = true;
        }

        private bool Existe(Producto p)
        {
            List<Producto> lista = _Coleccion.Buscar(p.Codigo);
            return lista.Count > 0;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbTipoProducto.SelectedIndex;
            Producto? producto = null;

            if (!TodoValidado())
                SystemSounds.Hand.Play();
            else
            {
                switch (selectedIndex)
                {
                    case 0:
                        producto = new Filtro();
                        ArmarCafe((Filtro)producto);
                        break;
                    case 1:
                        producto = new Espresso();
                        ArmarCafe((Espresso)producto);
                        break;
                    case 2:
                        producto = new Te();
                        ArmarTe((Te)producto);
                        break;
                    case 3:
                        producto = new Infusion();
                        ArmarInfusion((Infusion)producto);
                        break;
                }
            }

            if (producto != null)
            {
                ArmarProductoBase(producto);
                bool guardar = true;

                if (Existe(producto) && !tCodigo.Enabled)
                {
                    if (MessageBox.Show("¿Está seguro de que desea actualizar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Coleccion.Eliminar(producto);
                        guardar = true;
                    }
                }

                else if (Existe(producto) && tCodigo.Enabled)
                {
                    MessageBox.Show("Ya existe producto con ese código", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tCodigo.Focus(); ep.SetError(tCodigo, "Código repetido");
                    guardar = false;
                }


                if (guardar)
                {
                    _Coleccion.Agregar(producto);
                    MessageBox.Show(producto.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FormularioPrincipal.actualizarListBoxYControles();
                    LimpiarCampos();
                }
            }
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
        private void tCodigo_Validated(object sender, EventArgs e)
        {
            if (tCodigo.Text == "Código" || int.Parse(tCodigo.Text) <= 0) ep.SetError(tCodigo, "Código inválido");
            else ep.SetError(tCodigo, "");
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
        private void tCodigo_Enter(object sender, EventArgs e)
        {
            if (tCodigo.Text == "Código")
            {
                tCodigo.Text = "";
                tCodigo.ForeColor = Color.Black;
            }
        }

        private void tCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tCodigo.Text))
            {
                tCodigo.Text = "Código";
                tCodigo.ForeColor = Color.Gray;
            }
        }
        private void colorTextBox()
        {
            tCodigo.ForeColor = Color.Black; tNombre.ForeColor = Color.Black; tPrecio.ForeColor = Color.Black;
            tOrigen.ForeColor = Color.Black;
            rtDescripcion.ForeColor = Color.Black;
        }
        #endregion

        #region KeyPress
        private void tPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }
        private void tCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        #endregion        
    }
}
