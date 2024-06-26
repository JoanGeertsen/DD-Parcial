using System.Diagnostics.Eventing.Reader;

namespace DD_Parcial
{
    public partial class FPrincipal : Form
    {
        #region Atributos
        private Coleccion _Coleccion;
        private FCarga _FormularioCarga;
        private FAcercaDe _FormularioAcercaDe;
        #endregion
        public FPrincipal()
        {
            InitializeComponent();
            _Coleccion = new Coleccion();
            _FormularioCarga = new FCarga(_Coleccion, this);
            _FormularioAcercaDe = new FAcercaDe();
            cbFiltros.SelectedIndex = 0;
            cbTipoTe.SelectedIndex = 0;
            cbTueste.SelectedIndex = 0;
        }

        #region Funcionalidades      
        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (_FormularioCarga.IsDisposed) _FormularioCarga = new FCarga(_Coleccion, this);
            _FormularioCarga.Show(); _FormularioCarga.BringToFront();
        }
        private void habilitarControles()
        {
            int selectedIndex = cbFiltros.SelectedIndex;
            if (selectedIndex == 0) { pCafe.Enabled = false; pTe.Enabled = false; }
            else if (selectedIndex == 1) { pCafe.Enabled = true; pTe.Enabled = false; }
            else if (selectedIndex == 2) { pCafe.Enabled = false; pTe.Enabled = true; }
            else if (selectedIndex == 3) { pCafe.Enabled = false; pTe.Enabled = false; }
        }

        private List<Producto> obtenerLista()
        {
            int selectedIndex = cbFiltros.SelectedIndex;

            List<Producto> lista = _Coleccion.Buscar(); //Todos los productos

            if (selectedIndex == 1 && chFiltro.Checked && chEspresso.Checked) //Caf�
            {
                if ((cbTueste.SelectedIndex == -1 || cbTueste.SelectedIndex == 0)) //Todos los tuestes
                    lista = _Coleccion.Buscar(typeof(Cafe));
                else lista = _Coleccion.Buscar(cbTueste.Text.Replace("Tueste", "").Trim(), typeof(Cafe)); //Cafe tueste especifico
            }

            else if (selectedIndex == 1 && chFiltro.Checked && !chEspresso.Checked) //Caf� para filtro
            {
                if ((cbTueste.SelectedIndex == -1 || cbTueste.SelectedIndex == 0))
                    lista = _Coleccion.Buscar(typeof(Filtro));
                else lista = _Coleccion.Buscar(cbTueste.Text.Replace("Tueste", "").Trim(), typeof(Filtro));
            }

            if (selectedIndex == 1 && !chFiltro.Checked && chEspresso.Checked) //Caf� para espresso
            {
                if ((cbTueste.SelectedIndex == -1 || cbTueste.SelectedIndex == 0))
                    lista = _Coleccion.Buscar(typeof(Espresso));
                else lista = _Coleccion.Buscar(cbTueste.Text.Replace("Tueste", "").Trim(), typeof(Espresso));
            }

            else if (selectedIndex == 2)//T�
            {
                if (rbCualquiea.Checked && (cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    lista = _Coleccion.Buscar(typeof(Te));

                else if (rbCualquiea.Checked && !(cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    lista = _Coleccion.Buscar(cbTipoTe.Text.ToLower(), typeof(Te));

                else if ((rbLata.Checked || rbSobre.Checked) && (cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    lista = _Coleccion.Buscar(rbLata.Checked, typeof(Te));

                else if ((rbLata.Checked || rbSobre.Checked) && !(cbTipoTe.SelectedIndex == -1 || cbTipoTe.SelectedIndex == 0))
                    lista = _Coleccion.Buscar(rbLata.Checked, cbTipoTe.Text.ToLower(), typeof(Te));
            }

            else if (selectedIndex == 3)//Infusi�n           
                lista = _Coleccion.Buscar(typeof(Infusion));

            return lista;
        }

        public void actualizarListBoxYControles()
        {
            habilitarControles();

            lbProductos.Items.Clear();

            List<Producto> listaMostrar = obtenerLista();

            lCantidadEnPantalla.Text = $"Cantidad en pantalla: {listaMostrar.Count}";
            lCantidadTotal.Text = $"Cantidad de productos: {_Coleccion.Buscar().Count}";

            foreach (Producto p in listaMostrar)
                lbProductos.Items.Add(p.ToString());
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un item del listado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (lbProductos.Items.Count > 0) lbProductos.SetSelected(0, true);
            }
            else
            {
                if (_FormularioCarga.IsDisposed) _FormularioCarga = new FCarga(_Coleccion, this);
                _FormularioCarga.Show(); _FormularioCarga.BringToFront();

                List<Producto> lista = obtenerLista();
                Producto producto = lista[lbProductos.SelectedIndex];

                _FormularioCarga.Mostrar(producto);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un item del listado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (lbProductos.Items.Count > 0) lbProductos.SetSelected(0, true);
            }
            else if (MessageBox.Show("�Est� seguro que desea eliminar el producto?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<Producto> lista = obtenerLista();
                Producto producto = lista[lbProductos.SelectedIndex];
                _Coleccion.Eliminar(producto);
                actualizarListBoxYControles();
            }
        }
        private void bAcercaDe_Click(object sender, EventArgs e)
        {
            if (_FormularioAcercaDe.IsDisposed) _FormularioAcercaDe = new FAcercaDe();
            _FormularioAcercaDe.Show(); _FormularioAcercaDe.BringToFront();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}