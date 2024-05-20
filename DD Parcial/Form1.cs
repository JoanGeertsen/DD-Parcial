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

        private void button1_Click(object sender, EventArgs e)
        {
            if (_FormularioCarga.IsDisposed) _FormularioCarga = new FCarga(_Coleccion, this);
            _FormularioCarga.Show(); _FormularioCarga.BringToFront();
        }

        public void actualizarListBoxYControles()
        {
            int selectedIndex = cbFiltros.SelectedIndex;
            Type tipoSeleccionado = typeof(Producto);

            if (selectedIndex == 0) { pCafe.Enabled = true; pTe.Enabled = true; }
            if (selectedIndex == 1) { pCafe.Enabled = true; pTe.Enabled = false; tipoSeleccionado = typeof(Cafe); }
            if (selectedIndex == 2) { pCafe.Enabled = false; pTe.Enabled = true; tipoSeleccionado = typeof(Te); }
            if (selectedIndex == 3) { pCafe.Enabled = false; pTe.Enabled = false; tipoSeleccionado = typeof(Infusion); }

            lbProductos.Items.Clear();
           
            List<Producto> aux = _Coleccion.Buscar(tipoSeleccionado);
            foreach (Producto p in aux)                
                lbProductos.Items.Add(p.ToString());                      
        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBoxYControles();
        }
    }
}