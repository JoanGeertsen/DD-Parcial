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
            if(_FormularioCarga.IsDisposed) _FormularioCarga = new FCarga(_Coleccion, this);
            _FormularioCarga.Show(); _FormularioCarga.BringToFront();
        }
    }
}