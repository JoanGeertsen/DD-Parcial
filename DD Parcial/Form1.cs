using System.Diagnostics.Eventing.Reader;

namespace DD_Parcial
{
    public partial class FPrincipal : Form
    {
        #region Atributos
        private Coleccion _Coleccion;
        private FCarga _FormularioCarga;
        #endregion
        public FPrincipal()
        {
            InitializeComponent();
            _Coleccion = new Coleccion();
            _FormularioCarga = new FCarga(_Coleccion, this);
        }

        #region Funcionalidades
        private void button1_Click(object sender, EventArgs e)
        {
            if (_FormularioCarga.IsDisposed) _FormularioCarga = new FCarga(_Coleccion, this);
            _FormularioCarga.Show(); _FormularioCarga.BringToFront();
        }

        private void habilitarControles()
        {
            int selectedIndex = cbFiltros.SelectedIndex;
            if (selectedIndex == 1) { pCafe.Enabled = true; pTe.Enabled = false; }
            else if (selectedIndex == 2) { pCafe.Enabled = false; pTe.Enabled = true; }
            else if (selectedIndex == 3) { pCafe.Enabled = false; pTe.Enabled = false; }
        }

        public void actualizarListBoxYControles()
        {
            habilitarControles();
            int selectedIndex = cbFiltros.SelectedIndex;
            lbProductos.Items.Clear();

            List<Producto> listaMostrar = _Coleccion.Buscar(); //Todos los productos

            if (selectedIndex == 1 && chFiltro.Checked && chEspresso.Checked) //Café
            {
                if ((cbTueste.SelectedIndex == -1 || cbTueste.SelectedIndex == 0)) //Todos los tuestes
                    listaMostrar = _Coleccion.Buscar(typeof(Cafe));
                else listaMostrar = _Coleccion.Buscar(cbTueste.Text.Replace("Tueste", "").Trim(), typeof(Cafe)); //Cafe tueste especifico
            }

            else if (selectedIndex == 1 && chFiltro.Checked && !chEspresso.Checked) //Café para filtro
            {
                if ((cbTueste.SelectedIndex == -1 || cbTueste.SelectedIndex == 0))
                    listaMostrar = _Coleccion.Buscar(typeof(Filtro));
                else listaMostrar = _Coleccion.Buscar(cbTueste.Text.Replace("Tueste", "").Trim(), typeof(Filtro));
            }

            if (selectedIndex == 1 && !chFiltro.Checked && chEspresso.Checked) //Café para espresso
            {
                if ((cbTueste.SelectedIndex == -1 || cbTueste.SelectedIndex == 0))
                    listaMostrar = _Coleccion.Buscar(typeof(Espresso));
                else listaMostrar = _Coleccion.Buscar(cbTueste.Text.Replace("Tueste", "").Trim(), typeof(Espresso));
            }

            else if (selectedIndex == 2)//Té
            {
                if (rbCualquiea.Checked && (cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    listaMostrar = _Coleccion.Buscar(typeof(Te));

                else if (rbCualquiea.Checked && !(cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    listaMostrar = _Coleccion.Buscar(cbTipoTe.Text.ToLower(), typeof(Te));

                else if ((rbLata.Checked || rbSobre.Checked) && (cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    listaMostrar = _Coleccion.Buscar(rbLata.Checked, typeof(Te));

                else if ((rbLata.Checked || rbSobre.Checked) && !(cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    listaMostrar = _Coleccion.Buscar(rbLata.Checked, cbTipoTe.Text.ToLower(), typeof(Te));
            }

            else if (selectedIndex == 3)//Infusión           
                listaMostrar = _Coleccion.Buscar(typeof(Infusion));

            foreach (Producto p in listaMostrar)
                lbProductos.Items.Add(p.ToString());
        }
        #endregion

        #region Paneles
        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }

        private void chFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (!chEspresso.Checked) chFiltro.Checked = true;
            actualizarListBoxYControles();
        }

        private void chEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (!chFiltro.Checked) chEspresso.Checked = true;
            actualizarListBoxYControles();
        }

        private void cbTueste_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }

        private void cbTipoTe_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }

        private void rbCualquiea_CheckedChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }

        private void rbLata_CheckedChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }

        private void rbSobre_CheckedChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if(lbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un item del listado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (lbProductos.Items.Count > 0) lbProductos.SetSelected(0, true);
            }
            else
            {
                if (_FormularioCarga.IsDisposed) _FormularioCarga = new FCarga(_Coleccion, this);
                _FormularioCarga.Show(); _FormularioCarga.BringToFront();
            }
        }
    }
}